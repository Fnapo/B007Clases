using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B007Clases.Models;

public partial class Cliente
{
    [Key]
    public long IdCliente { get; set; }

    [Required(ErrorMessage = "El Nombre es obligatorio")]
    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(100)]
    [Required(ErrorMessage = "Los Apellidos son obligatorios")]
    public string Apellidos { get; set; } = null!;

    [StringLength(50)]
    [RegularExpression(@"^[a-z0-9\-+_]+@[a-z0-9\-+_]+\.([a-z]{2,3})$", ErrorMessage = "El formato del Email no es válido")]
    [Required(ErrorMessage = "El Email es obligatorio")]
    public string Email { get; set; } = null!;

    [StringLength(50)]
    [Required(ErrorMessage = "El Teléfono es obligatorio")]
    public string Telefono { get; set; } = null!;

    public DateOnly FechaAlta { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Creado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Modificado { get; set; }
}
