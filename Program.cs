//start main
string enjoymentLevel = GetEnjoymentLevel();
string stadiumRec = GetStadiumRec(enjoymentLevel);
string game = getGameRec(stadiumRec);
StadiumDetails(stadiumRec, game);
// end main

static string GetEnjoymentLevel()
{
    System.Console.WriteLine("Pick your ideal enjoyment level for a football game! Your choices are boring, average, fun, or epic!");
    return (Console.ReadLine().ToLower());
}

static string GetStadiumRec(string enjoymentLevel)
{
if (enjoymentLevel == "boring"){
    return "Neyland Stadium";
    }
else if (enjoymentLevel == "average"){
        return "Jordan-Hare Stadium";
    }
else if (enjoymentLevel == "fun"){
    return "Tiger Stadium";
    }
 else if (enjoymentLevel == "epic"){
    return "Saban-Field at Bryant Denny Stadium";
    }
else{
return "unknown";
    }
}


static string getGameRec(string stadium)
{
if (stadium == "Neyland Stadium"){
    return "Kent State";
    }
else if (stadium == "Jordan-Hare Stadium"){
        return "Kentucky";
    }
else if (stadium == "Tiger Stadium"){
    return "Auburn";
    }
 else if (stadium == "Saban-Field at Bryant Denny Stadium"){
    return "Alabama";
    }
else{
return "unknown";
    }
}

static void StadiumDetails(string stadium, string game)
{
    System.Console.WriteLine($"We recommend going to {stadium} for a game against {game}! \n Thanks for using our program");
}