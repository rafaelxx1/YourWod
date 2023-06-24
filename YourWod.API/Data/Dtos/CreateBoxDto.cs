using System;
using YourWod.API.Models;

namespace YourWod.API.Data.Dtos;

public class CreateBoxDto
{


    public string Name { get; set; }
    public string Cep { get; set; }
    public DateTime Data { get; set; }
}

