- title : Exploring StackOverflow 
- description : Exploring StackOverflow with F# and R.
- author : Evelina Gabasova
- theme : white
- transition : none

***

- data-background: images/posts-background.png
- class : withbackground

# <div style="color: white" > Exploring StackOverflow </div>
## <div style="color: white" > Evelina Gabasova </div>
## <div style="color: white" > @evelgab </div>

------------------------------------------------------------------------------------------------

<img src="images/so-logo.png" /> 

------------------------------------------------------------------------------------------------

- data-background: #d3d3d3

<img src="images/copypaste.jpg" style="height: 640px" />

------------------------------------------------------------------------------------------------

- data-background: #d3d3d3

![](images/api.png)

------------------------------------------------------------------------------------------------

- data-background: #d3d3d3

![](images/archive.png)

------------------------------------------------------------------------------------------------

- data-background : black

<img src="images/files.png" style="width: 960px" />

' 135 GB approx


************************************************************************************************

- data-background: images/posts-background.png
- class : withbackground

<h1 style="font-size:200pt"> ? </h1>

------------------------------------------------------------------------------------------------

![](images/profile1.png)

------------------------------------------------------------------------------------------------

![](images/profile2.png)

------------------------------------------------------------------------------------------------

# Question: Where?

' Are there local pockets for some of the languages?
' Where is each technology used?
' technology: type providers for JSON & Bing, HTML & Wikipedia, charting
' insights: technology countries, where are programmers concentrated

------------------------------------------------------------------------------------------------

# Where?

- 5 277 833 users in total

- 769 541 filled in their location

------------------------------------------------------------------------------------------------

- data-background : black

### $HOME

------------------------------------------------------------------------------------------------

- data-background : black

# 83%

------------------------------------------------------------------------------------------------

- data-background : black

### (Unfortunately) Germany

------------------------------------------------------------------------------------------------

- data-background : black

### 7151 Mawson Station, Australian Antarctic Territory, Antarctica

------------------------------------------------------------------------------------------------

- data-background : images/antarctica.jpg

------------------------------------------------------------------------------------------------

- data-background: images/posts-background.png
- class : withbackground 

# Where?

' demo: JSON type provider + Bing map API

------------------------------------------------------------------------------------------------

### Javascript

<script type="text/javascript" src="https://www.google.com/jsapi"></script>
<script type="text/javascript">
google.load("visualization", "1", {packages:["geochart"]})
google.setOnLoadCallback(drawChart);
function drawChart() {
var data = new google.visualization.DataTable({"cols": [{"type": "string" ,"id": "Column 1" ,"label": "Column 1" }, {"type": "number" ,"id": "Column 2" ,"label": "Column 2" }], "rows" : [{"c" : [{"v": "United States"}, {"v": 49103}]}, {"c" : [{"v": "Canada"}, {"v": 7213}]}, {"c" : [{"v": "United Kingdom"}, {"v": 13960}]}, {"c" : [{"v": "Turkey"}, {"v": 1550}]}, {"c" : [{"v": "Australia"}, {"v": 4874}]}, {"c" : [{"v": "India"}, {"v": 26724}]}, {"c" : [{"v": "Israel"}, {"v": 1481}]}, {"c" : [{"v": "South Africa"}, {"v": 1356}]}, {"c" : [{"v": "Denmark"}, {"v": 1471}]}, {"c" : [{"v": "Georgia"}, {"v": 253}]}, {"c" : [{"v": "Netherlands"}, {"v": 4358}]}, {"c" : [{"v": "Sweden"}, {"v": 2615}]}, {"c" : [{"v": "France"}, {"v": 4910}]}, {"c" : [{"v": "Colombia"}, {"v": 482}]}, {"c" : [{"v": "Belgium"}, {"v": 1807}]}, {"c" : [{"v": "Ireland"}, {"v": 1232}]}, {"c" : [{"v": "New Zealand"}, {"v": 1204}]}, {"c" : [{"v": "Lebanon"}, {"v": 194}]}, {"c" : [{"v": "Hungary"}, {"v": 659}]}, {"c" : [{"v": "Norway"}, {"v": 1154}]}, {"c" : [{"v": "Finland"}, {"v": 775}]}, {"c" : [{"v": "Germany"}, {"v": 7863}]}, {"c" : [{"v": "Mexico"}, {"v": 1100}]}, {"c" : [{"v": "Philippines"}, {"v": 1220}]}, {"c" : [{"v": "Poland"}, {"v": 2486}]}, {"c" : [{"v": "Argentina"}, {"v": 1115}]}, {"c" : [{"v": "Paraguay"}, {"v": 50}]}, {"c" : [{"v": "Spain"}, {"v": 2658}]}, {"c" : [{"v": "Chile"}, {"v": 398}]}, {"c" : [{"v": "Belarus"}, {"v": 555}]}, {"c" : [{"v": "Latvia"}, {"v": 315}]}, {"c" : [{"v": "Thailand"}, {"v": 326}]}, {"c" : [{"v": "Japan"}, {"v": 720}]}, {"c" : [{"v": "Austria"}, {"v": 1022}]}, {"c" : [{"v": "Lithuania"}, {"v": 365}]}, {"c" : [{"v": "Luxembourg"}, {"v": 72}]}, {"c" : [{"v": "Russia"}, {"v": 3218}]}, {"c" : [{"v": "Brazil"}, {"v": 3600}]}, {"c" : [{"v": "Iceland"}, {"v": 118}]}, {"c" : [{"v": "Singapore"}, {"v": 893}]}, {"c" : [{"v": "Oman"}, {"v": 1312}]}, {"c" : [{"v": "Croatia"}, {"v": 401}]}, {"c" : [{"v": "Kenya"}, {"v": 224}]}, {"c" : [{"v": "Switzerland"}, {"v": 1561}]}, {"c" : [{"v": "Honduras"}, {"v": 36}]}, {"c" : [{"v": "Uruguay"}, {"v": 212}]}, {"c" : [{"v": "Bolivia"}, {"v": 62}]}, {"c" : [{"v": "Bangladesh"}, {"v": 1002}]}, {"c" : [{"v": "Pakistan"}, {"v": 2056}]}, {"c" : [{"v": "Puerto Rico"}, {"v": 67}]}, {"c" : [{"v": "Italy"}, {"v": 2707}]}, {"c" : [{"v": "Estonia"}, {"v": 268}]}, {"c" : [{"v": "Greece"}, {"v": 742}]}, {"c" : [{"v": "Myanmar"}, {"v": 107}]}, {"c" : [{"v": "Slovakia"}, {"v": 363}]}, {"c" : [{"v": "Portugal"}, {"v": 1107}]}, {"c" : [{"v": "Czech Republic"}, {"v": 1069}]}, {"c" : [{"v": "Malaysia"}, {"v": 539}]}, {"c" : [{"v": "Bulgaria"}, {"v": 702}]}, {"c" : [{"v": "Gabon"}, {"v": 6}]}, {"c" : [{"v": "China"}, {"v": 2578}]}, {"c" : [{"v": "Serbia"}, {"v": 487}]}, {"c" : [{"v": "Trinidad and Tobago"}, {"v": 25}]}, {"c" : [{"v": "Slovenia"}, {"v": 292}]}, {"c" : [{"v": "Taiwan"}, {"v": 340}]}, {"c" : [{"v": "Ukraine"}, {"v": 2630}]}, {"c" : [{"v": "El Salvador"}, {"v": 75}]}, {"c" : [{"v": "Jordan"}, {"v": 240}]}, {"c" : [{"v": "Guatemala"}, {"v": 81}]}, {"c" : [{"v": "Central African Republic"}, {"v": 10}]}, {"c" : [{"v": "Armenia"}, {"v": 155}]}, {"c" : [{"v": "Dominica"}, {"v": 128}]}, {"c" : [{"v": "United Arab Emirates"}, {"v": 365}]}, {"c" : [{"v": "Peru"}, {"v": 208}]}, {"c" : [{"v": "Moldova"}, {"v": 109}]}, {"c" : [{"v": "Botswana"}, {"v": 15}]}, {"c" : [{"v": "Venezuela"}, {"v": 247}]}, {"c" : [{"v": "Egypt"}, {"v": 661}]}, {"c" : [{"v": "Cambodia"}, {"v": 115}]}, {"c" : [{"v": "Costa Rica"}, {"v": 168}]}, {"c" : [{"v": "Samoa"}, {"v": 2}]}, {"c" : [{"v": "Ecuador"}, {"v": 85}]}, {"c" : [{"v": "Macedonia"}, {"v": 123}]}, {"c" : [{"v": "Saint Lucia"}, {"v": 2}]}, {"c" : [{"v": "Iran"}, {"v": 1246}]}, {"c" : [{"v": "Indonesia"}, {"v": 963}]}, {"c" : [{"v": "Greenland"}, {"v": 4}]}, {"c" : [{"v": "Madagascar"}, {"v": 22}]}, {"c" : [{"v": "Palestine"}, {"v": 51}]}, {"c" : [{"v": "Kyrgyzstan"}, {"v": 44}]}, {"c" : [{"v": "Antigua and Barbuda"}, {"v": 11}]}, {"c" : [{"v": "Albania"}, {"v": 66}]}, {"c" : [{"v": "Qatar"}, {"v": 38}]}, {"c" : [{"v": "Malta"}, {"v": 121}]}, {"c" : [{"v": "San Marino"}, {"v": 2}]}, {"c" : [{"v": "Afghanistan"}, {"v": 62}]}, {"c" : [{"v": "Saudi Arabia"}, {"v": 137}]}, {"c" : [{"v": "Vietnam"}, {"v": 691}]}, {"c" : [{"v": "Bosnia and Herzegovina"}, {"v": 150}]}, {"c" : [{"v": "Panama"}, {"v": 48}]}, {"c" : [{"v": "Tunisia"}, {"v": 218}]}, {"c" : [{"v": "Heard Island and McDonald Islands"}, {"v": 1}]}, {"c" : [{"v": "Niger"}, {"v": 285}]}, {"c" : [{"v": "Syria"}, {"v": 64}]}, {"c" : [{"v": "Nepal"}, {"v": 487}]}, {"c" : [{"v": "Uzbekistan"}, {"v": 64}]}, {"c" : [{"v": "South Korea"}, {"v": 349}]}, {"c" : [{"v": "Solomon Islands"}, {"v": 6}]}, {"c" : [{"v": "Abkhazia"}, {"v": 7}]}, {"c" : [{"v": "Cyprus"}, {"v": 80}]}, {"c" : [{"v": "Micronesia"}, {"v": 4}]}, {"c" : [{"v": "Macao SAR"}, {"v": 6}]}, {"c" : [{"v": "Jamaica"}, {"v": 38}]}, {"c" : [{"v": "Kazakhstan"}, {"v": 100}]}, {"c" : [{"v": "Azerbaijan"}, {"v": 77}]}, {"c" : [{"v": "Uganda"}, {"v": 53}]}, {"c" : [{"v": "Bahrain"}, {"v": 34}]}, {"c" : [{"v": "Sri Lanka"}, {"v": 867}]}, {"c" : [{"v": "Bermuda"}, {"v": 6}]}, {"c" : [{"v": "Mali"}, {"v": 12}]}, {"c" : [{"v": "Guinea"}, {"v": 6}]}, {"c" : [{"v": "Nicaragua"}, {"v": 38}]}, {"c" : [{"v": "Antarctica"}, {"v": 8}]}, {"c" : [{"v": "Isle of Man"}, {"v": 12}]}, {"c" : [{"v": "Algeria"}, {"v": 127}]}, {"c" : [{"v": "Aruba"}, {"v": 5}]}, {"c" : [{"v": "Fiji"}, {"v": 10}]}, {"c" : [{"v": "Montenegro"}, {"v": 14}]}, {"c" : [{"v": "Rwanda"}, {"v": 6}]}, {"c" : [{"v": "Kuwait"}, {"v": 42}]}, {"c" : [{"v": "Morocco"}, {"v": 228}]}, {"c" : [{"v": "North Korea"}, {"v": 25}]}, {"c" : [{"v": "Mozambique"}, {"v": 12}]}, {"c" : [{"v": "Bahamas, The"}, {"v": 12}]}, {"c" : [{"v": "Romania"}, {"v": 116}]}, {"c" : [{"v": "Maldives"}, {"v": 22}]}, {"c" : [{"v": "Zimbabwe"}, {"v": 19}]}, {"c" : [{"v": "Yemen"}, {"v": 12}]}, {"c" : [{"v": "Seychelles"}, {"v": 2}]}, {"c" : [{"v": "Curacao"}, {"v": 12}]}, {"c" : [{"v": "Liberia"}, {"v": 1}]}, {"c" : [{"v": "Kosovo"}, {"v": 42}]}, {"c" : [{"v": "Andorra"}, {"v": 53}]}, {"c" : [{"v": "Belize"}, {"v": 6}]}, {"c" : [{"v": "Ghana"}, {"v": 60}]}, {"c" : [{"v": "Mauritius"}, {"v": 46}]}, {"c" : [{"v": "Reunion"}, {"v": 6}]}, {"c" : [{"v": "Brunei"}, {"v": 8}]}, {"c" : [{"v": "South Sudan"}, {"v": 3}]}, {"c" : [{"v": "Ethiopia"}, {"v": 53}]}, {"c" : [{"v": "Libya"}, {"v": 15}]}, {"c" : [{"v": "Senegal"}, {"v": 5}]}, {"c" : [{"v": "Cayman Islands"}, {"v": 11}]}, {"c" : [{"v": "Namibia"}, {"v": 11}]}, {"c" : [{"v": "Mongolia"}, {"v": 37}]}, {"c" : [{"v": "Marshall Islands"}, {"v": 19}]}, {"c" : [{"v": "Cuba"}, {"v": 66}]}, {"c" : [{"v": "Benin"}, {"v": 7}]}, {"c" : [{"v": "Chad"}, {"v": 8}]}, {"c" : [{"v": "Guyana"}, {"v": 5}]}, {"c" : [{"v": "Saba"}, {"v": 1}]}, {"c" : [{"v": "Angola"}, {"v": 8}]}, {"c" : [{"v": "Sudan"}, {"v": 6}]}, {"c" : [{"v": "Tanzania"}, {"v": 46}]}, {"c" : [{"v": "Cameroon"}, {"v": 37}]}, {"c" : [{"v": "Barbados"}, {"v": 11}]}, {"c" : [{"v": "Turks and Caicos Islands"}, {"v": 1}]}, {"c" : [{"v": "Jersey"}, {"v": 8}]}, {"c" : [{"v": "Mauritania"}, {"v": 4}]}, {"c" : [{"v": "Faroe Islands"}, {"v": 6}]}, {"c" : [{"v": "Guam"}, {"v": 2}]}, {"c" : [{"v": "Tajikistan"}, {"v": 6}]}, {"c" : [{"v": "Tuvalu"}, {"v": 1}]}, {"c" : [{"v": "French Polynesia"}, {"v": 3}]}, {"c" : [{"v": "Liechtenstein"}, {"v": 7}]}, {"c" : [{"v": "Gibraltar"}, {"v": 7}]}, {"c" : [{"v": "FYRO Macedonia"}, {"v": 8}]}, {"c" : [{"v": "Norfolk Island"}, {"v": 1}]}, {"c" : [{"v": "Vanuatu"}, {"v": 3}]}, {"c" : [{"v": "Bhutan"}, {"v": 10}]}, {"c" : [{"v": "Turkmenistan"}, {"v": 8}]}, {"c" : [{"v": "French-Guadeloupe"}, {"v": 3}]}, {"c" : [{"v": "Jan Mayen"}, {"v": 1}]}, {"c" : [{"v": "ZZZAbkhazia"}, {"v": 3}]}, {"c" : [{"v": "Haiti"}, {"v": 9}]}, {"c" : [{"v": "New Caledonia"}, {"v": 7}]}, {"c" : [{"v": "Zambia"}, {"v": 14}]}, {"c" : [{"v": "Suriname"}, {"v": 1}]}, {"c" : [{"v": "Midway Islands"}, {"v": 13}]}, {"c" : [{"v": "Grenada"}, {"v": 3}]}, {"c" : [{"v": "Malawi"}, {"v": 9}]}, {"c" : [{"v": "Kiribati"}, {"v": 4}]}, {"c" : [{"v": "Lesotho"}, {"v": 2}]}, {"c" : [{"v": "Cape Verde"}, {"v": 3}]}, {"c" : [{"v": "Congo (DRC)"}, {"v": 6}]}, {"c" : [{"v": "Iraq"}, {"v": 31}]}, {"c" : [{"v": "Laos"}, {"v": 2}]}, {"c" : [{"v": "Ivory Coast"}, {"v": 9}]}, {"c" : [{"v": "French-Martinique"}, {"v": 3}]}, {"c" : [{"v": "Burkina Faso"}, {"v": 5}]}, {"c" : [{"v": "Sierra Leone"}, {"v": 3}]}, {"c" : [{"v": "Dominican Republic"}, {"v": 8}]}, {"c" : [{"v": "Pitcairn Islands"}, {"v": 2}]}, {"c" : [{"v": "Svalbard"}, {"v": 1}]}, {"c" : [{"v": "Swaziland"}, {"v": 1}]}, {"c" : [{"v": "Monaco"}, {"v": 8}]}, {"c" : [{"v": "Northern Mariana Islands"}, {"v": 3}]}, {"c" : [{"v": "Guernsey"}, {"v": 2}]}, {"c" : [{"v": "Nigeria"}, {"v": 12}]}, {"c" : [{"v": "Republic of Korea"}, {"v": 1}]}, {"c" : [{"v": "Equatorial Guinea"}, {"v": 2}]}, {"c" : [{"v": "Timor-Leste"}, {"v": 1}]}, {"c" : [{"v": "Cook Islands"}, {"v": 1}]}, {"c" : [{"v": "Korea, North"}, {"v": 4}]}, {"c" : [{"v": "The Bahamas"}, {"v": 2}]}, {"c" : [{"v": "Pridnestrovie"}, {"v": 5}]}, {"c" : [{"v": "Transnistria"}, {"v": 1}]}, {"c" : [{"v": "Burundi"}, {"v": 1}]}, {"c" : [{"v": "Somalia"}, {"v": 3}]}, {"c" : [{"v": "Bouvet Island"}, {"v": 1}]}, {"c" : [{"v": "Papua New Guinea"}, {"v": 2}]}, {"c" : [{"v": "Gambia"}, {"v": 1}]}, {"c" : [{"v": "Tonga"}, {"v": 1}]}, {"c" : [{"v": "Togo"}, {"v": 2}]}, {"c" : [{"v": "East Timor"}, {"v": 1}]}, {"c" : [{"v": "Saint Barthelemy"}, {"v": 1}]}, {"c" : [{"v": "Christmas Island"}, {"v": 1}]}, {"c" : [{"v": "Saint Pierre and Miquelon"}, {"v": 1}]}, {"c" : [{"v": "Falkland Islands (Islas Malvinas)"}, {"v": 1}]}]});
    var options = {"legend":{"position":"none"},"width":1000,"height":600} ;
    var chart = new google.visualization.GeoChart(document.getElementById('c0946653-59db-4a2b-95e2-a0ffa85d6dfb'));
    chart.draw(data, options);
}
</script>
<div id="c0946653-59db-4a2b-95e2-a0ffa85d6dfb" style="width: 800px; height: 600px;"></div>

------------------------------------------------------------------------------------------------

$$$
n \times \frac{1}{\text{population}} \times \frac{\text{registered}}{\text{located}}  \times 1,000,000

<br />
<br />

<div class="fragment"> 
### ppm (Programmers-per-million) 
</div>


------------------------------------------------------------------------------------------------

- data-background: images/posts-background.png
- class : withbackground 

# Where really?

' we need population
' demo: HTML type provider

------------------------------------------------------------------------------------------------

#### F#

<script type="text/javascript">
    google.load("visualization", "1", {packages:["geochart"]})
    google.setOnLoadCallback(drawChart);
function drawChart() {
    var data = new google.visualization.DataTable({"cols": [{"type": "string" ,"id": "Column 1" ,"label": "Column 1" }, {"type": "number" ,"id": "Column 2" ,"label": "Column 2" }], "rows" : [{"c" : [{"v": "United States"}, {"v": 21.1441649612187}]}, {"c" : [{"v": "Australia"}, {"v": 33.5895256401621}]}, {"c" : [{"v": "Norway"}, {"v": 50.3885226982056}]}, {"c" : [{"v": "United Kingdom"}, {"v": 41.0609702691429}]}, {"c" : [{"v": "Poland"}, {"v": 9.21370207660584}]}, {"c" : [{"v": "New Zealand"}, {"v": 38.2940917317782}]}, {"c" : [{"v": "Netherlands"}, {"v": 27.2895993705161}]}, {"c" : [{"v": "Russia"}, {"v": 3.50390962731898}]}, {"c" : [{"v": "Canada"}, {"v": 21.2922413531757}]}, {"c" : [{"v": "India"}, {"v": 0.313034807609634}]}, {"c" : [{"v": "Brazil"}, {"v": 0.974474222519289}]}, {"c" : [{"v": "Sweden"}, {"v": 53.8960153684717}]}, {"c" : [{"v": "Switzerland"}, {"v": 25.8064642993965}]}, {"c" : [{"v": "Ireland"}, {"v": 36.4866453176332}]}, {"c" : [{"v": "Germany"}, {"v": 11.069909152792}]}, {"c" : [{"v": "Israel"}, {"v": 24.2741968485698}]}, {"c" : [{"v": "Denmark"}, {"v": 81.9457102597392}]}, {"c" : [{"v": "Belgium"}, {"v": 10.4248090891128}]}, {"c" : [{"v": "France"}, {"v": 6.34725338483007}]}, {"c" : [{"v": "Spain"}, {"v": 2.8411379457247}]}, {"c" : [{"v": "Turkey"}, {"v": 0.617316339027548}]}, {"c" : [{"v": "Guatemala"}, {"v": 0.429280799661604}]}, {"c" : [{"v": "Austria"}, {"v": 16.6815705617765}]}, {"c" : [{"v": "Italy"}, {"v": 4.92200989513662}]}, {"c" : [{"v": "South Africa"}, {"v": 2.49547075908887}]}, {"c" : [{"v": "Colombia"}, {"v": 0.568768047380725}]}, {"c" : [{"v": "China"}, {"v": 20.7944073955373}]}, {"c" : [{"v": "Japan"}, {"v": 0.710813724612141}]}, {"c" : [{"v": "Czech Republic"}, {"v": 21.7033563800386}]}, {"c" : [{"v": "Finland"}, {"v": 13.8987443946405}]}, {"c" : [{"v": "Saint Lucia"}, {"v": 37.3338887616799}]}, {"c" : [{"v": "South Korea"}, {"v": 0.137189030091987}]}, {"c" : [{"v": "Mexico"}, {"v": 0.323905558943612}]}, {"c" : [{"v": "Macedonia"}, {"v": 3.35256943281996}]}, {"c" : [{"v": "Oman"}, {"v": 18.5309511105928}]}, {"c" : [{"v": "Greece"}, {"v": 5.75583221422658}]}, {"c" : [{"v": "Madagascar"}, {"v": 0.309529774019991}]}, {"c" : [{"v": "Ukraine"}, {"v": 6.18582690419955}]}, {"c" : [{"v": "Malaysia"}, {"v": 0.437327411888557}]}, {"c" : [{"v": "Uruguay"}, {"v": 1.995304698859}]}, {"c" : [{"v": "Georgia"}, {"v": 3.7329874796648}]}, {"c" : [{"v": "Philippines"}, {"v": 0.202233838415483}]}, {"c" : [{"v": "Indonesia"}, {"v": 0.133242702070996}]}, {"c" : [{"v": "Trinidad and Tobago"}, {"v": 5.14504934155792}]}, {"c" : [{"v": "Egypt"}, {"v": 0.227474147792854}]}, {"c" : [{"v": "Portugal"}, {"v": 3.35745175411309}]}, {"c" : [{"v": "Argentina"}, {"v": 1.11512450373723}]}, {"c" : [{"v": "Bulgaria"}, {"v": 5.82413724792847}]}, {"c" : [{"v": "Bosnia and Herzegovina"}, {"v": 1.96652241082105}]}, {"c" : [{"v": "Singapore"}, {"v": 17.564127612541}]}, {"c" : [{"v": "Malta"}, {"v": 16.1737518392535}]}, {"c" : [{"v": "Iran"}, {"v": 0.611166794297645}]}, {"c" : [{"v": "Slovakia"}, {"v": 2.55944740851418}]}, {"c" : [{"v": "Sri Lanka"}, {"v": 0.662415654838544}]}, {"c" : [{"v": "Lithuania"}, {"v": 14.5328093793667}]}, {"c" : [{"v": "Estonia"}, {"v": 42.2151903708514}]}, {"c" : [{"v": "Paraguay"}, {"v": 1.01306686691447}]}, {"c" : [{"v": "Hungary"}, {"v": 5.65538292551966}]}, {"c" : [{"v": "Peru"}, {"v": 1.10263416871329}]}, {"c" : [{"v": "Moldova"}, {"v": 1.95437879870323}]}, {"c" : [{"v": "Botswana"}, {"v": 3.11268445302353}]}, {"c" : [{"v": "Dominica"}, {"v": 81.9457102597392}]}, {"c" : [{"v": "Slovenia"}, {"v": 26.9233339410991}]}, {"c" : [{"v": "Pakistan"}, {"v": 0.178740477775467}]}, {"c" : [{"v": "Kazakhstan"}, {"v": 0.391146571303903}]}, {"c" : [{"v": "El Salvador"}, {"v": 3.19480880875329}]}, {"c" : [{"v": "Jamaica"}, {"v": 2.54993610921395}]}, {"c" : [{"v": "Ecuador"}, {"v": 0.417987076041062}]}, {"c" : [{"v": "Belarus"}, {"v": 6.57862418811075}]}, {"c" : [{"v": "Serbia"}, {"v": 3.92523361387584}]}, {"c" : [{"v": "Croatia"}, {"v": 4.97111795969029}]}, {"c" : [{"v": "Uganda"}, {"v": 0.188386188917079}]}, {"c" : [{"v": "Chile"}, {"v": 0.763428043214008}]}, {"c" : [{"v": "Cuba"}, {"v": 2.47143014084609}]}, {"c" : [{"v": "Bhutan"}, {"v": 8.92523849937978}]}, {"c" : [{"v": "Cyprus"}, {"v": 8.198469078716}]}, {"c" : [{"v": "United Arab Emirates"}, {"v": 1.40911187290431}]}, {"c" : [{"v": "Vietnam"}, {"v": 0.224728262448947}]}, {"c" : [{"v": "Mauritius"}, {"v": 5.49862917165655}]}, {"c" : [{"v": "Saudi Arabia"}, {"v": 0.223887784806559}]}, {"c" : [{"v": "Thailand"}, {"v": 0.211294647909894}]}, {"c" : [{"v": "Latvia"}, {"v": 3.54508030920587}]}, {"c" : [{"v": "Bangladesh"}, {"v": 0.0431093878835645}]}, {"c" : [{"v": "Niger"}, {"v": 0.335221014225076}]}, {"c" : [{"v": "San Marino"}, {"v": 81.9457102597392}]}, {"c" : [{"v": "Palestine"}, {"v": 1.4417313369622}]}, {"c" : [{"v": "Tunisia"}, {"v": 0.622543866964826}]}, {"c" : [{"v": "Kyrgyzstan"}, {"v": 1.14820319945641}]}, {"c" : [{"v": "Azerbaijan"}, {"v": 0.711814187860433}]}, {"c" : [{"v": "Venezuela"}, {"v": 0.223796140659211}]}, {"c" : [{"v": "South Korea"}, {"v": 0.137189030091987}]}, {"c" : [{"v": "Marshall Islands"}, {"v": 81.9457102597392}]}]});
    var options = {"legend":{"position":"none"},"width":1000,"height":600} 
    var chart = new google.visualization.GeoChart(document.getElementById('2f1227d9-f924-4eed-ad93-6fe640abde4c'));
    chart.draw(data, options);
}
</script>
<div id="2f1227d9-f924-4eed-ad93-6fe640abde4c" style="width: 800px; height: 600px;"></div>

------------------------------------------------------------------------------------------------



------------------------------------------------------------------------------------------------

- data-background : images/dominican-republic.jpg

------------------------------------------------------------------------------------------------

- data-background : #121412

## (Sampling bias)

<img src="images/skull.jpg" style="width: 200px" />

' only registered users
' only active users
' and out of them, only the ones that gave out their address

************************************************************************************************

<img src="images/so-structure-tags.png" style="width:960px" />

------------------------------------------------------------------------------------------------

# Tags + Users

<div class="fragment">

# = 
# Communities

</div>

' Users ask questions with specific tags & answer questions with specific tags
' No-one knows everything

' how to define relation between tags through posts & users, similar users - similar tags
' memory vs. distributed computing
' t-SNE visualization - how to create a meaningful visualization
' Networks
' technology: RProvider, Fable

------------------------------------------------------------------------------------------------

# Tags 

### define 

# relations



------------------------------------------------------------------------------------------------

|           | F# | C# | JS | R | Cobol |
|-----------|----|----|------------|---|---|
| Evelina   | 1  | 0  | 1          | 1 | 0 |
| Tomas | 1  | 1  | 1          | 0 | 0 |

------------------------------------------------------------------------------------------------

### 44 265 tags x  5 277 831 users

------------------------------------------------------------------------------------------------

#### Users with more than 1,000 posts
#### Tags with more than 5,000 posts

<div class="fragment">
## 807 tags, 1633 power users
</div>

------------------------------------------------------------------------------------------------

# t-SNE
## t-distributed Stochastic Neighbourhood embedding

------------------------------------------------------------------------------------------------

# Embedding

------------------------------------------------------------------------------------------------

<img src="images/tsne-explanation0.png" />

------------------------------------------------------------------------------------------------

<img src="images/tsne-explanation1.png" />

------------------------------------------------------------------------------------------------

<img src="images/tsne-explanation2.png" />

------------------------------------------------------------------------------------------------

<img src="images/tsne-explanation3.png" />

------------------------------------------------------------------------------------------------

<img src="images/tsne-explanation4.png" />

------------------------------------------------------------------------------------------------

<img src="images/tsne-explanation5.png" />

------------------------------------------------------------------------------------------------
# t-SNE in R

    [lang=R]
    library(tsne)

    ts <- tsne(m, perplexity=20)

    plot(ts)

------------------------------------------------------------------------------------------------

# t-SNE in F#

    open RProvider
    open RProvider.tsne

    let ts = R.tsne(namedParams[ "X", box m; "perplexity", box 20])

    R.plot(ts)

------------------------------------------------------------------------------------------------

- data-background : images/rplot.png

------------------------------------------------------------------------------------------------

*The best thing about R is that it was written by statisticians.*
<div class="fragment">
*The worst thing about R is that it was written by statisticians.*
</div>
<br />

Bow Cowgill, 2009

------------------------------------------------------------------------------------------------

## fable.io

![](images/fable.png)

------------------------------------------------------------------------------------------------

- data-background : images/tsne-full.png

------------------------------------------------------------------------------------------------

<img src="images/tsne-example1.png" style="height: 640px" />

------------------------------------------------------------------------------------------------

<img src="images/tsne-example2.png" style="height: 640px" />

------------------------------------------------------------------------------------------------

<img src="images/tsne-example3.png" style="width: 960px" />

------------------------------------------------------------------------------------------------

<img src="images/hapmap-tsne.png" style="height: 550px" />

Platzer, A. (2013). Visualization of SNPs with t-SNE. PLoS ONE, 8(2), e56883. 


************************************************************************************************

- data-background : images/beach.jpg

<table>
<tr>
  <td class="noborder" style="width:60%;"></td>
   <td class="noborder" style="width:40%;">

<h2> <div style="color: white" > Evelina Gabasova </div> </h2>
<div style="color: white" >
@evelgab <br />
evelinag.com<br />
</div>
<br /><br /><br/><br/><br/><br/>
</td> 
</tr>
</table>

