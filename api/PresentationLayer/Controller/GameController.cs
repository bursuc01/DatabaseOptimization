using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class GameController : ControllerBase
{
    private readonly Context _context;

    public GameController(Context context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Games>>> GetGames()
    {
        return await _context.Games.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Games>> GetGame(int id)
    {
        var game = await _context.Games.FindAsync(id);

        if (game == null)
        {
            return NotFound();
        }

        return game;
    }
}