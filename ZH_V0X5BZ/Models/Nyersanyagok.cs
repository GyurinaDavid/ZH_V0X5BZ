﻿using System;
using System.Collections.Generic;

namespace ZH_V0X5BZ.Models;

public partial class Nyersanyagok
{
    public int NyersanyagId { get; set; }

    public string? NyersanyagNev { get; set; }

    public int? MennyisegiEgysegId { get; set; }

    public decimal? Egysegar { get; set; }

    public virtual MennyisegiEgysegek? MennyisegiEgyseg { get; set; }

    public virtual ICollection<Receptek> Recepteks { get; } = new List<Receptek>();
}
