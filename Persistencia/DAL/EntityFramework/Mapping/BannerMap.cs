﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Dominio;

namespace Persistencia.DAL.EntityFramework.Mapping
{
    class BannerMap : EntityTypeConfiguration<Banner>
    {
        /// <summary>
        /// Configuraciones correspondientes a los atributos de Banner.
        /// </summary>
        public BannerMap()
        {
            this.Property(b => b.BannerId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(b => b.Nombre)
                .IsRequired();
        }
    }
