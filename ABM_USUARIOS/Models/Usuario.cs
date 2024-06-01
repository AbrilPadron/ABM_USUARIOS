using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ABM_USUARIOS.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    [Display(Name = "Usuario")]
    public string Usuario1 { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string? Nombre { get; set; }

    public string Apellido { get; set; } = null!;

    [Display(Name = "Dirección")]
    public string Direccion { get; set; } = null!;

    [Display(Name = "Fecha de Nacimiento")]
    public DateTime? FechaNac { get; set; }

    public string Email { get; set; } = null!;

    [Display(Name = "Teléfono")]
    public string? Telefono { get; set; }

    public string? Ciudad { get; set; }

    [Display(Name = "Código Postal")]
    public string? CodPostal { get; set; }
}
