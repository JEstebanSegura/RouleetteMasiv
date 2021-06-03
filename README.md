# RouleetteMasiv
Test Backend. Api for an online betting rouletta
From Postman:
Create table.
Created: 92afcc66-d8a3-4d3d-a293-b8e185d998cd
Open table:
Opened: 92afcc66-d8a3-4d3d-a293-b8e185d998cd
Bet:
{
    "id": "92afcc66-d8a3-4d3d-a293-b8e185d998cd",
    "status": true,
    "openedAt": "2021-06-03T13:51:36.3209532-05:00",
    "closedAt": "0001-01-01T00:00:00",
    "winnerBox": -1,
    "winnerColor": null,
    "bets": [
        {
            "userId": "Esteban",
            "money": 4000,
            "box": 27,
            "color": "Red"
        }
    ],
    "results": null
}
Close table:
{
    "id": "92afcc66-d8a3-4d3d-a293-b8e185d998cd",
    "status": false,
    "openedAt": "2021-06-03T13:51:36.3209532-05:00",
    "closedAt": "2021-06-03T13:52:19.5339828-05:00",
    "winnerBox": 16,
    "winnerColor": "Red",
    "bets": [
        {
            "userId": "Esteban",
            "money": 4000,
            "box": 27,
            "color": "Red"
        }
    ],
    "results": [
        {
            "userId": "Esteban",
            "money": 7200
        }
    ]
}
