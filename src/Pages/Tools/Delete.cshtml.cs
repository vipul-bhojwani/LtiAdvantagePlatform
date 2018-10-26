﻿using System.Threading.Tasks;
using AdvantagePlatform.Data;
using IdentityServer4.EntityFramework.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdvantagePlatform.Pages.Tools
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _appContext;
        private readonly IConfigurationDbContext _identityContext;
        private readonly UserManager<AdvantagePlatformUser> _userManager;

        public DeleteModel(
            ApplicationDbContext appContext,
            IConfigurationDbContext identityContext, 
            UserManager<AdvantagePlatformUser> userManager)
        {
            _appContext = appContext;
            _identityContext = identityContext;
            _userManager = userManager;
        }

        public ToolModel Tool { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);

            var tool = await _appContext.Tools.FindAsync(id);

            if (tool == null || tool.UserId != user.Id)
            {
                return NotFound();
            }

            var client = await _identityContext.Clients.FindAsync(tool.IdentSvrClientId);

            if (client == null)
            {
                return NotFound();
            }

            Tool = new ToolModel
            {
                Id = tool.Id,
                ClientId = client.ClientId,
                DeploymentId = tool.DeploymentId,
                Name = tool.Name,
                Url = tool.Url
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return Page();
            }

            var tool = await _appContext.Tools.FindAsync(id);

            if (tool != null)
            {
                var client = await _identityContext.Clients.FindAsync(tool.IdentSvrClientId);

                if (client != null)
                {
                    _identityContext.Clients.Remove(client);
                    await _identityContext.SaveChangesAsync();
                }

                _appContext.Tools.Remove(tool);
                await _appContext.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
