using System;
using System.Data.Linq.Mapping;
using System.Windows.Forms;

namespace Firma
{
    [Table(Name = "FakturySprzedaży")]
    class FakturaSprzedaży
    {
        [Column(Name = "Id", IsPrimaryKey = true, CanBeNull = false)] public int Id;
        [Column(CanBeNull = false)] public string Numer;
        [Column(CanBeNull = false)] public double Netto;
        [Column(CanBeNull = false)] public double VAT;
        [Column(CanBeNull = false)] public double Zaplacono;
        [Column(CanBeNull = false)] public DateTime Data;
        [Column(CanBeNull = false)] public int KontrahentId;
        [Column(CanBeNull = false)] public int PracownikId;
    }
}