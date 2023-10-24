type Details = {
    name : string
    description : string
}

type Item = {
    Details : Details
}

type RoomId =
    | RoomId of string

type Exit =
    | PassableExit of Details * destination : RoomId
    | LockedExit of Details * key : Item
    | NoExit of Details option

type Exits = {
    North : Exit
    South : Exit
    East : Exit
    West : Exit
}

type Room = {
    Id : RoomId
    Details : Details
    Items : Item list
    Exits : Exits
}

type Player = {
    Details : Details
    Location : RoomId
    Inventory : Item list
}

type World = {
    Rooms : Map<RoomId, Room>
    Player : Player 
}

