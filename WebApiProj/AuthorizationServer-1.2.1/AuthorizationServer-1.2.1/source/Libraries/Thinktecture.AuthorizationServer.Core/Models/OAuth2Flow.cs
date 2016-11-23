﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license.txt
 */

namespace Thinktecture.AuthorizationServer.Models
{
    public enum OAuthFlow
    {
        Code,
        Implicit,
        ResourceOwner,
        Client, 
        Assertion
    }
}
