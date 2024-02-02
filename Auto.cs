using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlAuto;

public class Auto
{
    string _farbe;
    int _ps;
    string _marke;

    public Auto(int ps, string marke, string farbe)
    {
        this._ps = ps;
        this._marke = marke;
        this._farbe = farbe;
    }

    public Auto(int ps, string marke)
    {
        this._ps=ps;
        this._marke=marke;
        this._farbe = "weiß";
    }
    public string GetFarbe()
    {
        return _farbe;
    }
    public string GetMarke()
    {
        return _marke;
    }
    public int GetPs() 
    {
        return _ps;
    }
    public void Fahre()
    {
        Console.WriteLine("Das Auto mit der Farbe {0} fährt:", GetFarbe());
        //_farbe anstatt GetFarbe auch möglich oder Farbe
        Console.WriteLine("Brumm Brumm Brumm ...");
    }
}
