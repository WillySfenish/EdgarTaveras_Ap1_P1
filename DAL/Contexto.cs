﻿using EdgarTaveras_Ap1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace EdgarTaveras_Ap1_P1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }
    public DbSet<Registros> Registros { get; set; }
}

