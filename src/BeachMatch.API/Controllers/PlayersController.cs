using BeachMatch.Application.DTOs.Player;
using BeachMatch.Application.Interfaces.Services;
using BeachMatch.Application.Mappers;
using BeachMatch.Application.Services;
using BeachMatch.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BeachMatch.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayersController : ControllerBase
{
    private readonly IPlayerService _playerService;

    public PlayersController(IPlayerService playerService)
    {
        _playerService = playerService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreatePlayerRequest request)
    {
        var player = PlayerMapper.ToEntity(request);
        await _playerService.CreatePlayerAsync(player);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var players = await _playerService.GetAllPlayersAsync();

        var response = PlayerMapper.ToResponseList(players);

        return Ok(response);
    }

    [HttpGet("{guid}")]
    public async Task<IActionResult> GetPlayerByGuid(Guid guid)
    {
        var player = await _playerService.GetPlayerByIdAsync(guid);
        var response = PlayerMapper.ToResponse(player);

        if (response == null)
            return NotFound();
        
        return Ok(response);
    }
}
