using System;
namespace UXDivers.Artina.Grial
{
	public class Vehicule
	{
		public int vehiculeID { get; set; }
		public string numImmatriculation { get; set; }
		public DateTime datePremiereImmatriculation { get; set; }
		public string constructeur { get; set; }
		public int cylindree { get; set; }
		public int puissanceMaximale { get; set; }
		public string typeDeCarburant { get; set; }
		public DateTime annéeDeConstruction { get; set;}
	}
}
