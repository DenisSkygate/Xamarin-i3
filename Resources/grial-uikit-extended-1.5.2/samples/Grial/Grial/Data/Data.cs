using System;
namespace UXDivers.Artina.Grial
{
	public class Data
	{
		public Data()
		{
			Vehicule maVoiture = new Vehicule();
			maVoiture.vehiculeID = 1;
			maVoiture.numImmatriculation = "1-ERR-404";
			maVoiture.datePremiereImmatriculation = new DateTime(1921,09,1);
			maVoiture.constructeur = "Ford";
			maVoiture.cylindree = 8;
			maVoiture.puissanceMaximale = 589;
			maVoiture.typeDeCarburant = "essances";
			maVoiture.annéeDeConstruction = new DateTime(1920,1,1);

			Personne moi = new Personne();
			moi.nom = "Omelcenco";
			moi.prenom = "Denis";
			moi.dateNaissance = new DateTime(1990, 12, 9);

			moi.vehicules.Add(maVoiture);

			AutoritesPublique police = new AutoritesPublique();
			police.nom = "Police";


		}
	}
}
