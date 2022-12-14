using System;
using System.Collections.Generic;

namespace ZH_V0X5BZ.Models;

public partial class Fogasok
{
    public int FogasId { get; set; }

    public string? FogasNev { get; set; }

    public byte[]? Kep { get; set; }

    public string? Leiras { get; set; }

    public virtual ICollection<Receptek> Recepteks { get; } = new List<Receptek>();
}
