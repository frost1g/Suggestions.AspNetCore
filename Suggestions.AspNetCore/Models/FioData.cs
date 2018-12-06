﻿namespace Suggestions.AspNetCore.Models
{
    public class FioData
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string gender { get; set; }
    }

    public enum FioPart
    {
        SURNAME,
        NAME,
        PATRONYMIC
    }

}