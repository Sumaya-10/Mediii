using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediPlusAB108.Models;

namespace MediPlusAB108.Data;

public class MediPlusAB108Context : DbContext
{
	public DbSet<Slider> Sliders { get; set; }

	public MediPlusAB108Context(DbContextOptions options) : base(options)
	{
	}
}
