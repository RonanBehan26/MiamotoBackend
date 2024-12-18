using MiamotMusahiQuotes.Models;
using Microsoft.AspNetCore.Mvc;

namespace MiamotMusahiQuotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtworksController : ControllerBase
    {
        private static readonly List<Artwork> Artworks = new()
        {
            new Artwork
            {
                Id = 1,
                Title = "The Great Wave off Kanagawa",
                Artist = "Hokusai",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Tsunami_by_hokusai_19th_century.jpg/1280px-Tsunami_by_hokusai_19th_century.jpg",
                Description = "The iconic Great Wave by Hokusai, symbolizing strength and beauty."
            },
            new Artwork
            {
                Id = 2,
                Title = "Portrait of Miyamoto Musashi",
                Artist = "Ueno Shunri",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/42/Miyamoto_Musashi_Self-Portrait.jpg",
                Description = "Historical portrait of the famous swordsman"
            }
        };

        [HttpGet]
        public IActionResult GetArtworks()
        {
            return Ok(Artworks);
        }
    }
}
