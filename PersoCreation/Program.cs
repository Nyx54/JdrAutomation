using System.Reflection;
using System.Text;

var perso = new Perso();

Console.WriteLine($"Je suis issu du milieu :{Environment.NewLine}1 - Ouvrier/Paysan{Environment.NewLine}2 - Artisan{Environment.NewLine}3 - Bourgeois{Environment.NewLine}4 - Aristocratique");
var milieu = Console.ReadLine();
switch (milieu)
{
    case "1":
        perso.Vigueur++;
        break;
    case "2":
        perso.Habilete++;
        break;
    case "3":
        perso.Intellect++;
        break;
    case "4":
        perso.Sociabilité++;
        break;
}


Console.WriteLine($"Mon milieu familial :{Environment.NewLine}1 - Je suis fils unique{Environment.NewLine}2 - J'ai un grand frère/soeur{Environment.NewLine}3 - j'ai un ou deux petits frères/soeurs{Environment.NewLine}4 - je suis le plus jeune d'une famille nombreuse{Environment.NewLine}5 - je suis l'ainé d'une famille nombreuse{Environment.NewLine}6 - je fais partie d'une famille nombreuse");

var famille = Console.ReadLine();
switch (famille)
{
    case "1":
        perso.Intellect++;
        perso.Raisonner++;
        break;
    case "2":
        perso.Vigueur++;
        perso.CbtMainNue++;
        break;
    case "3":
        perso.Habilete++;
        perso.Commandement++;
        break;
    case "4":
        perso.Sociabilité++;
        perso.Survie++;
        break;
    case "5":
        perso.Sociabilité++;
        perso.Commandement++;
        break;
    case "6":
        perso.Sociabilité++;
        perso.Perception++;
        break;
}

Console.WriteLine($"Dans ma jeunesse :{Environment.NewLine}1 - j'ai passé mon temps à trainer dans les rues{Environment.NewLine}2 - J'ai travaillé au champs/à la mine{Environment.NewLine}3 - j'ai fréquenté les banc de l'école publique{Environment.NewLine}4 - j'ai bénéficié d'un précepteur");

var jeunesse = Console.ReadLine();
switch (jeunesse)
{
    case "1":
        perso.Vigueur++;
        perso.Habilete++;
        perso.Larcin++;
        break;
    case "2":
        perso.Vigueur++;
        perso.Habilete++;
        perso.CbtMainNue++;
        break;
    case "3":
        perso.Intellect++;
        perso.Sociabilité++;
        perso.CultureG++;
        break;
    case "4":
        perso.Intellect++;
        perso.Sociabilité++;
        perso.Protocole++;
        break;
}

Console.WriteLine($"J'ai : {Environment.NewLine}1 - Entre 16 et 24 ans{Environment.NewLine}2 - Entre 25 et 37 ans{Environment.NewLine}3 - Entre 38 et 50 ans{Environment.NewLine}4 - 51 ans et +");

var age = Console.ReadLine();
switch (age)
{
    case "1":
        perso.Vigueur++;
        perso.Habilete++;
        perso.Accrobaties++;
        perso.Course++;
        perso.Seduction++;
        perso.Protocole--;
        perso.Commandement--;
        perso.CultureG--;
        break;
    case "2":
        perso.Vigueur++;
        perso.CbtMainNue++;
        perso.Perception++;
        perso.Persuasion++;
        break;
    case "3":
        perso.Intellect++;
        perso.Sociabilité++;
        perso.CultureG++;
        perso.Raisonner++;
        perso.Perception++;
        break;
    case "4":
        perso.Vigueur--;
        perso.Habilete--;
        perso.Intellect++;
        perso.Sociabilité++;
        perso.Protocole++;
        perso.Commandement++;
        perso.CultureG++;
        perso.Persuasion++;
        perso.Raisonner++;
        perso.Perception--;
        perso.Discretion--;
        break;
}

Console.WriteLine($"J'exerce la profession de :{Environment.NewLine}1 - Voleur/cambrioleur{Environment.NewLine}2 - Enseignant{Environment.NewLine}3 - Agent de la force publique{Environment.NewLine}4 - Militaire de carrière{Environment.NewLine}5 - Ouvrier/Paysan{Environment.NewLine}6 - Artisan{Environment.NewLine}7 - Commerçant{Environment.NewLine}8 - Bureaucrate{Environment.NewLine}9 - Élu{Environment.NewLine}10 - Rentier{Environment.NewLine}11 - Patron d'entreprise{Environment.NewLine}12 - Aucune (Noble héritier, prérequis : issu d'un milieu aristocratique){Environment.NewLine}13 - Scientifique/Chercheur{Environment.NewLine}14 - Mécanicien{Environment.NewLine}15 - Médecin");

int ageModifier = 0;
if (!int.TryParse(age, out ageModifier))
{
    ageModifier = 1;
}
var emploi = Console.ReadLine();
switch (emploi)
{
    case "1":
        perso.Larcin += ageModifier;
        perso.Perception++;
        perso.Discretion++;
        break;
    case "2":
        perso.CultureG += ageModifier;
        perso.Persuasion++;
        perso.Raisonner++;
        break;
    case "3":
        perso.Intimidation += ageModifier;
        perso.Pistage++;
        perso.Course++;
        break;
    case "4":
        perso.TirLeger += ageModifier;
        perso.Camouflage++;
        perso.Commandement++;
        perso.Grade = (GradeEnum)ageModifier;
        break;
    case "5":
        perso.Survie += ageModifier;
        perso.CbtMainNue++;
        perso.Perception++;
        break;
    case "6":
        perso.Negociation += ageModifier;
        perso.Mecanique++;
        perso.CultureG++;
        break;
    case "7":
        perso.Negociation += ageModifier;
        perso.CultureG++;
        perso.Perception++;
        break;
    case "8":
        perso.CultureG++;
        perso.Falsification += ageModifier;
        perso.Persuasion++;
        break;
    case "9":
        perso.CultureG++;
        perso.Seduction += ageModifier;
        perso.Protocole++;
        break;
    case "10":
        perso.CultureG++;
        perso.Negociation += ageModifier;
        perso.Intimidation++;
        break;
    case "11":
        perso.CultureG++;
        perso.Negociation++;
        perso.Persuasion += ageModifier;
        break;
    case "12":
        perso.Protocole += ageModifier;
        perso.CultureG++;
        perso.Seduction++;
        break;
    case "13":
        Console.WriteLine(ListSciences());
        var scienceStr = Console.ReadLine();
        var science = int.Parse(scienceStr);
        perso.Science.Add((ScienceEnum)science, 2);
        perso.CultureG += ageModifier;
        break;
    case "14":
        perso.Mecanique += ageModifier;
        perso.CultureG++;
        perso.CbtArme++;
        break;
    case "15":
        perso.Soins += ageModifier;
        perso.CultureG++;
        perso.Compatir++;
        break;
}

perso.LastCalcul();

Console.WriteLine(perso.ToString());
Console.ReadLine();



static string ListSciences()
{
    var sb = new StringBuilder();
    PropertyInfo[] properties = typeof(Perso).GetProperties();
    foreach (int v in Enum.GetValues(typeof(ScienceEnum)))
    {
        sb.AppendLine($"{v} : {Enum.GetName(typeof(ScienceEnum), v)}");
    }
    return sb.ToString();

}

public class Perso
{
    public GradeEnum Grade { get; set; }
    public int PV { get; set; }
    public int Chance { get; set; }
    public int Nevrose { get; set; }

    #region Attributs

    public int Intellect { get; set; }
    public int Sociabilité { get; set; }
    public int Habilete { get; set; }
    public int Vigueur { get; set; }


    #endregion

    #region Competences

    // Combat
    public int CbtMainNue { get; set; }
    public int CbtArme { get; set; }
    public int TirLeger { get; set; }
    public int TirLourd { get; set; }
    public int Artillerie { get; set; }
    public int Lancer { get; set; }

    // Sociabilité
    public int Persuasion { get; set; }
    public int Intimidation { get; set; }
    public int Seduction { get; set; }
    public int Negociation { get; set; }
    public int Compatir { get; set; }
    public int Protocole { get; set; }
    public int Commandement { get; set; }

    // Physique
    public int Escalade { get; set; }
    public int Natation { get; set; }
    public int Course { get; set; }
    public int Accrobaties { get; set; }
    public int Camouflage { get; set; }
    public int Discretion { get; set; }

    // Intellect
    public int Raisonner { get; set; }
    public int Perception { get; set; }
    public int ConduiteMoteur { get; set; }
    public int ConduiteTraction { get; set; }
    public SciencesComp Science { get; set; }
    public int Orientation { get; set; }
    public int Pistage { get; set; }
    public int Survie { get; set; }
    public int Dressage { get; set; }
    public int Falsification { get; set; }
    public int Larcin { get; set; }
    public int CultureG { get; set; }
    public int Mecanique { get; set; }
    public int Explosif { get; set; }
    public int Soins { get; set; }

    #endregion

    public Perso()
    {
        Grade = GradeEnum.Soldat;
        PV = 0;
        Chance = 0;
        Nevrose = 0;

        Intellect = 2;
        Sociabilité = 2;
        Habilete = 2;
        Vigueur = 2;

        CbtMainNue = 0;
        CbtArme = 0;
        TirLeger = 0;
        TirLourd = 0;
        Artillerie = 0;
        Lancer = 0;

        Persuasion = 0;
        Intimidation = 0;
        Seduction = 0;
        Negociation = 0;
        Raisonner = 0;
        Compatir = 0;
        Protocole = 0;
        Commandement = 0;

        Escalade = 0;
        Natation = 0;
        Course = 0;
        Accrobaties = 0;
        Camouflage = 0;
        Discretion = 0;
        Perception = 0;

        ConduiteMoteur = 0;
        ConduiteTraction = 0;
        Science = new SciencesComp();
        Orientation = 0;
        Pistage = 0;
        Survie = 0;
        Dressage = 0;
        Falsification = 0;
        Larcin = 0;
        CultureG = 0;
        Mecanique = 0;
        Explosif = 0;
        Soins = 0;
    }

    internal void LastCalcul()
    {
        PV = 5 * (Vigueur + Habilete);
        Chance = 6;
        Nevrose = (Intellect + Sociabilité) * 5;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        PropertyInfo[] properties = typeof(Perso).GetProperties();
        foreach (PropertyInfo property in properties)
        {
            sb.AppendLine($"{property.Name} : {property.GetValue(this)}");
        }
        return sb.ToString();
    }
}

public class SciencesComp
{
    public Dictionary<ScienceEnum, int> Sciences { get; set; }
    public SciencesComp()
    {
        Sciences = new Dictionary<ScienceEnum, int>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var s in Sciences)
        {
            sb.AppendLine(s.ToString());
        }
        return sb.ToString();
    }

    public void Add(ScienceEnum science, int comp)
    {
        if (Sciences.ContainsKey(science))
        {
            Sciences[science] += comp;
        }
        else
        {
            Sciences.Add(science, comp);
        }
    }
}

public enum GradeEnum
{
    Colonel = 13,
    LieutenantColonel = 12,
    Commandant = 11,
    Capitaine = 10,
    Lieutenant = 9,
    SousLieutenant = 8,
    Aspirant = 7,
    AdjudantChef = 6,
    Adjudant = 5,
    SergentMajor = 4,
    Sergent = 3,
    Caporal = 2,
    PremiereClasse = 1,
    Soldat = 0
}

public enum ScienceEnum
{
    Biologie = 0,
    Physique = 1,
    Chimie = 2,
    HistoireGeo = 3,
    Astronomie = 4,
    Botanique = 5,
    Geologie = 6,
    Mecanique = 7,
    Ethnologie = 8,
    Economie = 9,
    Psycologie = 10,
    Philosophie = 11,
    Sociologie = 12,
    Pharmacologie = 13,
    Electronique = 14
}
