﻿using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IMatureCharacterBL
    {
        int AddMatureCharacter(MatureCharacterDTO u);
        bool DeleatMatureCharacter(int id);
        List<MatureCharacterDTO> GetAllMatureCharacter();
        bool UpdateMatureCharacter(int id, MatureCharacterDTO u);
    }
}