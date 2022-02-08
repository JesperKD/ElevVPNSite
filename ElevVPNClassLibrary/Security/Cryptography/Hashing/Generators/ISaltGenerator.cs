﻿namespace ElevVPNClassLibrary.Security.Cryptography.Hashing.Generators
{
    public interface ISaltGenerator
    {
        byte[] GenerateSalt(int saltLength = 32);
    }
}
