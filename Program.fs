type Details = {
    name : string
    description : string
}

type Exit =
    | PassableExit of Details * destination : Room
    | LockedExit of Details * key : Item
    | NoExit of Details


type Exits = {
    North : Exit
    South : Exit
    East : Exit
    West : Exit
}

type Room = {
    Details : Details
}



