using OnlineBibliotheek.Data.Models;
using Syncfusion.Blazor.Grids;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineBibliotheek.Pages.Library
{
    public partial class AuthorCatalogus
    {
        private IEnumerable<Auteur> gridData { get; set; }
        private List<Auteur> allAuthors = new List<Auteur>();

        protected override void OnInitialized()
        {
            allAuthors = _bblthkDbContext.Auteurs.ToList();
        }

        public void RowSelectHandler(RowSelectEventArgs<Auteur> args)
            => UriHelper.NavigateTo($"auteur/{Guid.Parse(args.Data.Id.ToString())}/bewerken", true);

        private void AddAuthor()
            => UriHelper.NavigateTo($"auteur/new/{true}", true);
    }
}
