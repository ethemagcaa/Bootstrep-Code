namespace TemelLayoutOrnek.Musteriveri
{
    public class Musteriveri
    {
        public static List<Models.Musteri> KMusteri = new List<Models.Musteri>
        {
            new Models.Musteri {
                ID = 1,
                Ad="Ali",
                Soyad="KAYA",
                Dogtar=Convert.ToDateTime("01/01/1990"),
                TcKimlikNo="12345678902",
                Adres="İstanbul/Türkiye"
            },
            new Models.Musteri
            {
                ID = 2,
                Ad="Ayşe",
                Soyad="Yıldız",
                Dogtar=Convert.ToDateTime("26/06/1991"),
                TcKimlikNo = "01254795597",
                Adres="Ankara/Türkiye"
            }

        };

    }
}
