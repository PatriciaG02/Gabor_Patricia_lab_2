﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gabor_Patricia_Lab2.Data;
using Gabor_Patricia_Lab2.Models;

namespace Gabor_Patricia_Lab2.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Gabor_Patricia_Lab2.Data.Gabor_Patricia_Lab2Context _context;

        public IndexModel(Gabor_Patricia_Lab2.Data.Gabor_Patricia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                 .ThenInclude(b => b.Author)
                .Include(b => b.Member).ToListAsync();
        }
    }
}