using System;
using System.Collections.Generic;
[Serializable]
public class StateClass
{
    public List<StateList> states;
}
[Serializable]
public class StateList
{
    public string name;
    public string flaeche;
    public string einwohner;
    public string bevoelkerungsdichte;
    public string ministerpraesident;
}
