﻿using System.Collections.Generic;

namespace Shield.Client.Fr.Models.API.Application
{
    public class ApplicationConfigurationDto
    {
        public bool InheritFromProject { get; set; }
        public string ProjectPreset { get; set; }
        
        public List<string> Protections { get; set; }
    }
}