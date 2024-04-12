using System;
using System.Data.Linq.Mapping;
using System.Windows.Forms;

namespace Firma
{
    [Table(Name = "Pracownicy")]
    class Pracownik
    {
        [Column(Name = "Id", IsPrimaryKey = true, CanBeNull = false)] public int Id;
        [Column(CanBeNull = false)] public string Imię;
        [Column(CanBeNull = false)] public string Nazwisko;
        [Column(CanBeNull = false)] public string Email;
        [Column(CanBeNull = false)] public string Telefon;
    }
}