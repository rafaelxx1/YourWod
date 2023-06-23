using System;
namespace YourWod.API.Data.Dtos;

public class UpdateAddressDto
{
    public string Cep { get; set; }
    public string Rua { get; set; }
    public string Estado { get; set; }
    public int Numero { get; set; }

}

