using Microsoft.EntityFrameworkCore;
using OnlineBibliotheek.Data.Models;
using Syncfusion.Blazor.Grids;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineBibliotheek.Pages.Library
{
    public partial class Catalogus
    {
        private List<Boek> allBooks = new List<Boek>();

        protected override void OnInitialized()
        {
            allBooks = _bblthkDbContext.Boeken.Include(x => x.Auteur).ToList();
        }

        public void RowSelectHandler(RowSelectEventArgs<Boek> args)
            => UriHelper.NavigateTo($"catalogus/boek/{Guid.Parse(args.Data.Id.ToString())}", true);

        private void AddBook()
            => UriHelper.NavigateTo($"catalogus/new/{true}", true);

        private void AddAuthor()
            => UriHelper.NavigateTo($"auteur/new/{true}", true);
    }
}
