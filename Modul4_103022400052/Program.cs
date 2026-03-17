using System;

class Program
{
    static void Main(string[] args)
    {
        //KodePaket kodePaket = new KodePaket();
        //Console.WriteLine("Masukkan nama paket (Basic, Standar, Premium, Unlimited, Gaming, Streaming, Family, Business, Student, Traveler):");
        //string namapaket = Console.ReadLine();
       // string kode = kodePaket.getKodePaket(namapaket);
       //Console.WriteLine($"Kode paket untuk {namapaket} adalah: {kode}");

        MesinKopi mesin = new MesinKopi();
        mesin.TriggerState(MesinKopi.Trigger.POWER_ON);
        mesin.TriggerState(MesinKopi.Trigger.START_BREW);
        mesin.TriggerState(MesinKopi.Trigger.FINISH_BREW);
        mesin.TriggerState(MesinKopi.Trigger.START_MAINTENANCE);
        mesin.TriggerState(MesinKopi.Trigger.FINISH_MAINTENANCE);
        mesin.TriggerState(MesinKopi.Trigger.POWER_OFF);
        mesin.PrintPesan(MesinKopi.State.OFF,MesinKopi.State.STANBY);
        mesin.PrintPesan(MesinKopi.State.STANBY, MesinKopi.State.BREWING);

    }
}
