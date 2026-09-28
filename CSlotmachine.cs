class CSlotmachine
{
    private float _soldi;
    private int _numeroVincite;
    private int _numeroPerdite;

    public float soldi
    {
        get{return _soldi;}
        set{_soldi = value;}
    }

    public int numeroVincite
    {
        get{return _numeroVincite;}
        set{_numeroVincite = value;}
    }

    public int numeroPerdite
    {
        get{return _numeroPerdite;}
        set{_numeroPerdite = value;}
    }

    public CSlotmachine()
    {
        _soldi = 100;
        _numeroVincite = 0;
        _numeroPerdite = 0;
    }

    public void AvviaSlotMachine(float bet)
    {
        if(bet > _soldi)
        {
            Console.WriteLine("Non puoi scommettere così tanto!");
        } else if (bet == 0 || bet == null)
        {
            Console.WriteLine("Il valore della scommessa non può essere nullo!");
        }
        else
        {
            _soldi -= bet;
            Random random = new Random();
            int n1 = random.Next(1, 11);
            int n2 = random.Next(1, 11); 
            int n3 = random.Next(1, 11);

            if(n1 == n2 && n2 == n3)
            {
                _soldi += bet * 2;
                Console.WriteLine($"{n1} | {n2} | {n3}");
                Console.WriteLine("JACKPOT!");
            } else if(n1 == n2 || n2 == n3 || n1 == n3)
            {
                _soldi += bet * 2 / 3;
                Console.WriteLine($"{n1} | {n2} | {n3}");
                Console.WriteLine("Vincita minima! Avrai più fortuna la prossima volta.");
            } else
            {
                Console.WriteLine($"{n1} | {n2} | {n3}");
                Console.WriteLine("Hai perso! Riprova.");
            }
        }
    }

    //da implementare in futuro il metodo HigherOrLower quando il problema dell'input sarà risolto

    public void Work()
    {
        Random random = new Random();
        int percentuale = random.Next(1, 101);
        
        if(percentuale <= 20)
        {
            int perdita = random.Next(150, 251);
            _soldi -= perdita;
            Console.WriteLine($"Andando a lavoro hai fatto un piccolo incidente e dal meccanico hai speso {perdita}€!");
        } else if(percentuale > 20 && percentuale <= 40)
        {
            int perdita = random.Next(50, 151);
            _soldi -= perdita;
            Console.WriteLine($"Dato che ci sono più di 150 e-mail da leggere, ti sei arrabbiato e hai distrutto la tastiera del pc dell'ufficio, la tastiera nuova ti è costata {perdita}€. Era una tastiera molto costosa.");
        } else if(percentuale > 40 && percentuale <= 60)
        {
            int perdita = random.Next(5, 21);
            _soldi -= perdita;
            Console.WriteLine($"Ti sei giocato {perdita}€ al gratta e vinci ma hai perso tutto.");
        } else if(percentuale > 60 && percentuale <= 80)
        {
            int guadagno = random.Next(30, 91);
            _soldi += guadagno;
            Console.WriteLine($"Oggi hai lavorato come giardiniere a casa della zia del tuo capo, guadagnando {guadagno}€ e un gelato.");
        } else if(percentuale > 80)
        {
            int guadagno = random.Next(50, 101);
            _soldi += guadagno;
            Console.WriteLine($"Oggi hai fatto gli straordinari, perciò il capo ha deciso di premiarti dandoti {guadagno}€.");
        }
    }

    public void Craps(float bet)
    {
        if(bet > _soldi)
        {
            Console.WriteLine("Non puoi scommettere così tanto!");
        } else
        {
            _soldi -= bet;
            Random random = new Random();
            int n1 = random.Next(1, 7);
            int n2 = random.Next(1, 7);

            if(n1 + n2 == 7 || n1 + n2 == 11)
            {
                _soldi += bet * 2;
                Console.WriteLine($"{n1} | {n2}");
                Console.WriteLine("Hai vinto!");
                Console.WriteLine($"Somma: {n1 + n2}");
            } else if(n1 + n2 == 2 || n1 + n2 == 3 || n1 + n2 == 12)
            {
                Console.WriteLine($"{n1} | {n2}");
                Console.WriteLine("Hai perso!");
                Console.WriteLine($"Somma: {n1 + n2}");
            } else if(n1 + n2 == 4 || n1 + n2 == 5 || n1 + n2 == 6 || n1 + n2 == 8 || n1 + n2 == 9 || n1 + n2 == 10)
            {
                _soldi += bet;
                Console.WriteLine($"{n1} | {n2}");
                Console.WriteLine($"POINT!");
                Console.WriteLine($"Somma: {n1 + n2}");
            }
        }
    }

    public void Roulette(float bet, string colore)
    {
        if(bet > _soldi)
        {
            Console.WriteLine("Non puoi scommettere così tanto!");
        } else
        {
            _soldi -= bet;
            
            Random random = new Random();
            int numColore = random.Next(1, 3);
            int Verde = random.Next(1, 38);
            if(Verde != 37 && numColore == 1 && colore == "rosso")
            {
                _soldi += bet * 2;
                Console.WriteLine($"Hai vinto! Hai puntato sul {colore}!");
            } else if(Verde != 37 && numColore == 2 && colore == "nero")
            {
                _soldi += bet * 2;
                Console.WriteLine($"Hai vinto! Hai puntato sul {colore}!");
            } else if(Verde == 37 && colore == "verde")
            {
                _soldi += bet * 5;
                Console.WriteLine($"HAI VINTO PUNTANDO SUL {colore}!!!!!");
            } else
            {
                if(numColore == 1 && Verde != 37)
                {
                    Console.WriteLine($"Hai perso! La pallina è caduta sul nero!");
                } else if(numColore == 2 && Verde != 37)
                {
                    Console.WriteLine($"Hai perso! La pallina è caduta sul rosso!");
                } else if(Verde == 37)
                {
                    Console.WriteLine("$Hai perso, la pallina è sorprendentemente caduta sul verde!");
                }
            }
        }
    }
    public void Visualizza()
    {
        Console.WriteLine($"Soldi Attuali: {_soldi}");
    }
}
