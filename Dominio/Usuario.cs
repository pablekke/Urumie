﻿using System;
using System.Collections.Generic;

namespace Dominio {

public partial class Usuario
{
    public int Id { get; set; }

    public string? Foto { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Email { get; set; }
    }
}
