using System;
using System.Data.Linq.Mapping;
using System.Windows.Forms;

namespace Firma
{
    [Table(Name = "Kontrahenci")]
    class Kontrahent
    {
        [Column(Name = "Id", IsPrimaryKey = true, CanBeNull = false)] public int Id;
        [Column(CanBeNull = false)] public string Nazwa;
        [Column(CanBeNull = false)] public string NIP;
        [Column(CanBeNull = false)] public string Ulica;
        [Column(CanBeNull = false)] public string Miasto;
    }
}