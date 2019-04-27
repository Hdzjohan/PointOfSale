﻿using System;
using System.Collections.Generic;

namespace PointOfSale.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            UsuarioRole = new HashSet<UsuarioRole>();
        }

        public string UsuarioId { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual ICollection<UsuarioRole> UsuarioRole { get; set; }
    }
}
