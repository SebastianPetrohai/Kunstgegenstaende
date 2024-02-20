using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunstgegenstaende;
/// <summary>
/// Erstellt einen Kunstgegenstand
/// </summary>
    public class Kunstgegenstand
    {

    string _titel;
    bool _verkaufbar = false;
    double _preis = 0;
    /// <summary>
    /// Erstellt einen Kunstgegenstand mit Namen
    /// </summary>
    /// <param name="titel">Der Name des Kunstgegenstandes</param>
    public Kunstgegenstand(string titel)
    {
        _titel = titel;
    }
    /// <summary>
    /// Erstellt einen Kunstgegenstan mit Namen und Festlegung, ob dieser verkaufbar ist
    /// </summary>
    /// <param name="titel">Der Name des Kunstgegenstandes</param>
    /// <param name="verkaufbar">Festlegung, ob dieser verkaufbar ist</param>
    public Kunstgegenstand(string titel, bool verkaufbar)
    {
        _titel = titel;
        _verkaufbar = verkaufbar;
    }
    public string GetTitel() {  return _titel; }
}

