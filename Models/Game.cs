using System;
using System.Collections.Generic;

#nullable disable

namespace MyMicroservice.Models
{
    public partial class Game
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
    }
}
