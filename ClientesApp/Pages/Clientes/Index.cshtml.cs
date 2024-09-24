using ClientesApp.Data;
using ClientesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClientesApp.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly ClientesDbContext _context;

        public IndexModel(ClientesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente Cliente { get; set; }
        public IList<Cliente> Clientes { get; set; }

        public async Task OnGetAsync(int? id)
        {
            Clientes = await _context.Clientes.ToListAsync();

            if (id != null)
            {
                Cliente = await _context.Clientes.FindAsync(id);
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Cliente.Id == 0)
            {
                _context.Clientes.Add(Cliente);
            }
            else
            {
                _context.Clientes.Update(Cliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetDelete(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }

    }
}
