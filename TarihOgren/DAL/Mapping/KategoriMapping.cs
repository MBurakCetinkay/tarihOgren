﻿using DATA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class KategoriMapping : EntityTypeConfiguration<Kategori>
    {
        public KategoriMapping()
        {
            ToTable("Kategori");

            Property(x => x.KategoriAd).IsRequired().HasMaxLength(30);
        }
    }
}