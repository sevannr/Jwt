﻿using System.Collections.Generic;

namespace Jwt.Models
{
    public class Country
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<State> States { get; set; }
    }
}
