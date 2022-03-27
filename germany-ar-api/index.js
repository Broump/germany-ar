const express = require("express")
const app = express()
const PORT = 8080

app.use(express.json())

app.get("/federal-states", (req, res) => {
    res.status(200).send({
        states: [
            {   
                name: "Nordrhein-Westfalen",
                flaeche: "34.110 km²",
                einwohner: "17.925.570",
                bevoelkerungsdichte: "526 pro km²",
                ministerpraesident: "Hendrik Wüst (CDU)",
            },
            {   
                name: "Bayern",
                flaeche: "70.541 km²",
                einwohner: "13.140.183",
                bevoelkerungsdichte: "186 pro km²",
                ministerpraesident: "Markus Söder (CSU)",
            },
            {   
                name: "Baden-Württemberg",
                flaeche: "35.751 km²",
                einwohner: "11.103.043",
                bevoelkerungsdichte: "311 pro km²",
                ministerpraesident: "Winfried Kretschmann (Grüne)",
            },
            {   
                name: "Niedersachsen",
                flaeche: "47.709 km²",
                einwohner: "8.003.421",
                bevoelkerungsdichte: "168 pro km²",
                ministerpraesident: "Stepahn Weil (SPD)",
            },
            {   
                name: "Hessen",
                flaeche: "21.114 km²",
                einwohner: "6.293.154",
                bevoelkerungsdichte: "298 pro km²",
                ministerpraesident: "Volker Bouffier (CDU)",
            },
            {   
                name: "Rheinland-Pfalz",
                flaeche: "19.854 km²",
                einwohner: "4.098.391",
                bevoelkerungsdichte: "206 pro km²",
                ministerpraesident: "Malu Dreyer (SPD)",
            },  
            {   
                name: "Sachsen",
                flaeche: "18.449 km²",
                einwohner: "4.056.941",
                bevoelkerungsdichte: "220 pro km²",
                ministerpraesident: "Michael Kretschmer (CDU)",
            },
            {   
                name: "Berlin",
                flaeche: "891 km²",
                einwohner: "3.664.088",
                bevoelkerungsdichte: "4.108 pro km²",
                ministerpraesident: "Franziska Giffey (SPD)",
            },
            {   
                name: "Schleswig-Holstein",
                flaeche: "15.799 km²",
                einwohner: "2.910.875",
                bevoelkerungsdichte: "184 pro km²",
                ministerpraesident: "Daniel Günther (CDU)",
            },
            {   
                name: "Brandenburg",
                flaeche: "29.654 km²",
                einwohner: "2.531.071",
                bevoelkerungsdichte: "85 pro km²",
                ministerpraesident: "Dietmar Woidke (SPD)",
            },
            {   
                name: "Sachsen-Anhalt",
                flaeche: "20.451 km²",
                einwohner: "2.180.684",
                bevoelkerungsdichte: "107 pro km²",
                ministerpraesident: "Reiner Haseloff (CDU)",
            },
            {   
                name: "Thüringen",
                flaeche: "16.202 km²",
                einwohner: "2.120.237",
                bevoelkerungsdichte: "131 pro km²",
                ministerpraesident: "Bodo Ramelow (Die Linke)",
            },
            {   
                name: "Hamburg",
                flaeche: "16.202 km²",
                einwohner: "1.851.430",
                bevoelkerungsdichte: "755 pro km²",
                ministerpraesident: "Peter Tschentscher (SPD)",
            },
            {   
                name: "Mecklenburg-Vorpommern",
                flaeche: "23.211 km²",
                einwohner: "1.610.774",
                bevoelkerungsdichte: "69 pro km²",
                ministerpraesident: "Manuela Schwesig (SPD)",
            },
            {   
                name: "Saarland",
                flaeche: "2.570 km²",
                einwohner: "983.991",
                bevoelkerungsdichte: "383 pro km²",
                ministerpraesident: "Tobias Hans (CDU)",
            },
            {   
                name: "Bremen",
                flaeche: "419 km²",
                einwohner: "680.130",
                bevoelkerungsdichte: "1622 pro km²",
                ministerpraesident: "Andreas Bovenschulte (SPD)",
            },
        ]
    })
})

app.listen(process.env.PORT || PORT, () => console.log("running on Port: " + PORT))