using System;

public class KodePaket
{
	public string getKodePaket(string namapaket)
	{
		string[] paket = {
		"Basic","Standar",
		"Premium","Unlimited",
		"Gaming","Streaming",
		"Family","Business",
		"Student","Traveler"
		};
		string[] kode = {
		"P201","P202",
		"P203","P204",
		"P205","P206",
		"P207","P208",
		"P209","P210"
		};

		for (int i = 0; i < paket.Length; i++) {
			if (paket[i] == namapaket) {
				return kode[i];
			}
		}
		return "Paket tidak ditemukan";
	}
}
