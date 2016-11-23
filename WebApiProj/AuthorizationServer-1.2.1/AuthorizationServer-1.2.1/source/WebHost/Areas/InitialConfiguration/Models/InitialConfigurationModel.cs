﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license.txt
 */

using System.ComponentModel.DataAnnotations;

namespace Thinktecture.AuthorizationServer.WebHost.Areas.InitialConfiguration.Models
{
    public class InitialConfigurationModel
    {
        [Required]
        [Display(Name="Server Name")]
        public string Name { get; set; }
        [Required]
        public string Issuer { get; set; }
        [Required]
        [Display(Name = "Administrator")]
        public string Admin { get; set; }
        public string Test { get; set; }
    }
}