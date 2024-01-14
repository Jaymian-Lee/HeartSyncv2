# HeartSync 🎵💖

HeartSync is more than just a dating app—it's a symphony of connections orchestrated by shared music preferences and passions. Dive into a world where genuine connections are fostered through the magic of music. Swipe, chat, and let HeartSync be the soundtrack to your love story.

## Features
- **Musical Matchmaking:** Discover potential connections based on shared music tastes. Our advanced matching algorithm ensures that you're paired with someone who resonates with your favorite tunes.

- **Passion Profiling:** Beyond music, HeartSync delves into your passions and hobbies. Whether you're into hiking, painting, or gaming, find someone who shares your enthusiasm.

- **Seamless Chats:** Engage in meaningful conversations with your potential matches. The HeartSync chat interface is designed for fluid communication, making it easy to connect on a deeper level.

- **Dynamic Swiping:** Swipe through profiles dynamically, enjoying smooth animations and an intuitive user interface. The more you swipe, the smarter HeartSync becomes in understanding your preferences.

- **Face Reveal:** Unveil the faces behind the hearts! After exchanging 100 messages, both you and your match are prompted to share a photo, adding a personal touch to your connection.

- **Event Synchronization:** Discover local events and activities based on your shared interests. Plan your next date or meetup directly within the app.

- **Personalized Recommendations:** Receive personalized recommendations for music, movies, and activities based on your profile and preferences, enhancing your overall HeartSync experience.

- **Privacy First:** We prioritize your privacy. Your data is securely handled, and you have control over what you share. We believe in fostering connections while ensuring a safe and respectful environment.

- **Profile Customization:** Showcase your personality! Customize your profile with photos, bio, and your favorite quotes. Let your potential matches get to know the real you.

- **Real-Time Notifications:** Stay in the loop with real-time notifications for new matches, messages, and activity updates. Never miss a chance to connect.

- **Feedback Mechanism:** Help us improve! Provide feedback on your HeartSync experience through the app. We value your input in making HeartSync better with each update.

## How to Run

### Prerequisites
- [.NET MAUI SDK](https://dotnet.microsoft.com/maui) installed on your machine.

### Steps
1. Clone the repository to your local machine.

    ```bash
    git clone https://github.com/your-username/heartsync.git
    ```

2. Navigate to the project directory.

    ```bash
    cd heartsync
    ```

3. Open the solution in Visual Studio or your preferred IDE.

4. Build and run the HeartSync MAUI app.

    ```bash
    dotnet build
    dotnet run --project src/HeartSync/HeartSync.maui.csproj
    ```

5. Experience the magic of HeartSync on your local machine!

## Contributing

We welcome contributions to make HeartSync even better. Feel free to submit issues, feature requests, or pull requests.

## Design
https://www.figma.com/file/wgF8prZ4caZOVC6NGJRsWr/HeartSync---Design?type=design&node-id=3-710&mode=design

## SRS

- ## Requirements
1.	De Gebruiker moet zich kunnen registreren voor de app.
2.	De Gebruiker moet kunnen inloggen met hun geregistreerde gegevens.
3.	De Gebruiker moet muziekinteresses kunnen opgeven bij de eerste aanmelding.
4.	De Gebruiker moet specifieke muziekinteresses kunnen selecteren door middel van buttons.
5.	De Gebruiker moet na het invullen van muziekinteresses naar het hoofdscherm worden geleid.
6.	De Gebruiker moet toegang hebben tot de navigatiebalk met opties voor 'Settings', 'Chats', en 'Profile'.
7.	De Gebruiker moet algemene app-instellingen kunnen aanpassen in het 'Settings'-gedeelte.
8.	De Gebruiker moet een overzicht kunnen zien van hun huidige gesprekken en actieve matches in het 'Chats'-gedeelte.
9.	De Gebruiker moet toegang hebben tot hun eigen profielinformatie in het 'Profile'-gedeelte.
10.	De Gebruiker moet binnen de app met andere gebruikers kunnen chatten.
11.	De Gebruiker moet een quiz naar hun match kunnen sturen als ijsbreker.
12.	Na het versturen van de quiz moet de Gebruiker de app kunnen gebruiken als een normale dating app.
13.	Na het uitwisselen van 100 berichten moet de Gebruiker een foto van zichzelf kunnen insturen.
14.	De Gebruiker moet matches kunnen vinden door te swipen op kaarten met muziekinteresses.
15.	De Gebruiker moet gedetailleerde profielen van andere gebruikers kunnen bekijken.
16.	De Gebruiker moet privacyinstellingen kunnen aanpassen op hun profiel.
17.	De Gebruiker moet notificaties kunnen ontvangen over nieuwe matches, berichten, en andere activiteiten.
18.	De Gebruiker moet andere gebruikers kunnen blokkeren of rapporteren in geval van ongepast gedrag.
19.	De Gebruiker moet matches kunnen vinden op basis van locatie met behulp van de app.
20.	De Gebruiker moet feedback kunnen geven over de app om deze te verbeteren.
21.	De Ontwikkelaar moet dynamisch nieuwe features kunnen integreren in de app.
22.	De Match moet moeiteloos zijn/haar muziekvoorkeuren kunnen bijwerken na de initiële registratie.
23.	De Gebruiker moet naadloos de quiz van hun Match kunnen ontvangen en direct invullen.
24.	De Gebruiker moet gedetailleerd notificatiebeheer hebben, inclusief de mogelijkheid om specifieke activiteiten te selecteren voor notificaties.
25.	De Gebruiker moet de app kunnen synchroniseren over verschillende apparaten met consistentie in gebruikerservaring.
26.	De Gebruiker moet gesprekken efficiënt kunnen markeren als favorieten voor snelle toegang.
27.	De Gebruiker moet probleemloos afbeeldingen kunnen delen in de chatinterface.
28.	De Gebruiker moet een overzichtelijke lijst hebben van gemeenschappelijke muziekinteresses met hun Match.
29.	De Gebruiker moet de resultaten van de quiz van hun Match direct kunnen inzien.
30.	De Gebruiker moet de app vloeiend kunnen laten draaien in de achtergrond zonder functioneel verlies.
31.	De Gebruiker moet flexibel deactiveren van hun account kunnen inzetten.
32.	De Gebruiker moet naadloos tussen meerdere talen kunnen schakelen binnen de app.
33.	De Gebruiker moet gericht kunnen zoeken naar andere gebruikers op basis van specifieke muzikale voorkeuren.
34.	De Gebruiker moet moeiteloos kunnen inloggen met biometrische gegevens voor een geavanceerde beveiligingservaring.
35.	De Gebruiker moet een gepersonaliseerde lijst kunnen samenstellen van favoriete nummers die prominent zichtbaar zijn op hun profiel.
36.	De Gebruiker moet gesprekken efficiënt kunnen archiveren voor een georganiseerde chatomgeving.
37.	De Gebruiker moet profielen van andere gebruikers naadloos kunnen delen via externe platforms.
38.	De Gebruiker moet real-time meldingen ontvangen bij het ontvangen van nieuwe quizresultaten.
39.	De Gebruiker moet de app naadloos kunnen ervaren in een visueel vriendelijke donkere modus.
40.	De Gebruiker moet proactieve, gepersonaliseerde suggesties ontvangen voor nieuwe matches op basis van hun unieke muziekvoorkeuren.

 
- ## Use Case Diagram V1
    ![UseCase - HeartSync](https://github.com/Jaymian-Lee/HeartSync/assets/56151997/27b08c16-cb6d-4cd9-95da-5f4d467ce584)


- ## Use Case Description V1
### Use Case 1: UC1 Account beheren

| Use Case | UC1: Account beheren |
|:----------------|:--------------------------|
| **Description** | Beheer van accountinstellingen, waaronder het wijzigen van persoonlijke informatie en voorkeuren. |
| **Actor** | Gebruiker |
| **Trigger(s)** | Gebruiker wil wijzigingen aanbrengen in hun accountinstellingen. |
| **Pre-Conditions** | Gebruiker is ingelogd op hun account. |
| **Post-Conditions** | Accountinformatie is bijgewerkt volgens de wijzigingen van de gebruiker. |
| **Steps** |
| Actor (User) | System |
| 1. Gebruiker navigeert naar de accountinstellingenpagina. | |
|  | 2. Toont de accountinstellingenpagina. |
| 3. Gebruiker wijzigt de gewenste informatie (bijv. naam, profielfoto, wachtwoord). | |
|  | 4. Slaat de wijzigingen op en update de accountinformatie. |
| **Main Success Scenario** | 
| 1. Gebruiker navigeert naar de accountinstellingenpagina. |
| 2. Toont de accountinstellingenpagina. |
| 3. Gebruiker wijzigt de gewenste informatie. |
| 4. Slaat de wijzigingen op en update de accountinformatie. |
| 5. **Gebruiker heeft succesvol hun accountinstellingen bijgewerkt.** |
| **Alternative Scenarios** | 
| - **Wrong Scenario: Gebruiker annuleert de wijzigingen.** |
|   1. Gebruiker klikt op "Annuleren". |
|   2. Systeem annuleert de wijzigingen en behoudt de vorige accountinformatie. |
| - **Wrong Scenario: Systeem kan de wijzigingen niet opslaan vanwege technische problemen.** |
|   1. Systeem toont een foutmelding. |
|   2. Gebruiker wordt geadviseerd het opnieuw te proberen. |

### Use Case 2: UC2 Gebruiker registreren

| Use Case | UC2: Gebruiker registreren |
|:----------------|:--------------------------|
| **Description** | Nieuwe gebruiker maakt een account aan op het platform. |
| **Actor** | Gebruiker |
| **Trigger(s)** | Gebruiker wil zich registreren voor een nieuw account. |
| **Pre-Conditions** | Geen bestaand account met het opgegeven e-mailadres. |
| **Post-Conditions** | Gebruiker heeft een nieuw account aangemaakt. |
| **Steps** |
| Actor (User) | System |
| 1. Gebruiker opent de registratiepagina. | |
|  | 2. Toont het registratieformulier. |
| 3. Gebruiker vult vereiste informatie in (naam, e-mail, wachtwoord). | |
|  | 4. Valideert ingevoerde gegevens en controleert op dubbele accounts. |
|  | 5. Maakt het nieuwe account aan en stuurt een bevestigingsbericht. |
| **Main Success Scenario** | 
| 1. Gebruiker opent de registratiepagina. |
| 2. Toont het registratieformulier. |
| 3. Gebruiker vult vereiste informatie in. |
| 4. Valideert ingevoerde gegevens en controleert op dubbele accounts. |
| 5. Maakt het nieuwe account aan en stuurt een bevestigingsbericht. |
| 6. **Gebruiker heeft succesvol een nieuw account aangemaakt.** |
| **Alternative Scenarios** | 
| - **Wrong Scenario: Gebruiker gebruikt een e-mailadres dat al is geregistreerd.** |
|   1. Systeem toont een foutmelding. |
|   2. Gebruiker wordt gevraagd een ander e-mailadres te gebruiken. |
| - **Wrong Scenario: Gebruiker vult ongeldige gegevens in.** |
|   1. Systeem toont een foutmelding bij ongeldige gegevens. |
|   2. Gebruiker corrigeert de gegevens en voltooit de registratie. |

### Use Case 3: UC3 Gebruiker inloggen

| Use Case | UC3: Gebruiker inloggen |
|:----------------|:--------------------------|
| **Description** | Gebruiker logt in op hun bestaande account. |
| **Actor** | Gebruiker |
| **Trigger(s)** | Gebruiker wil toegang tot hun account. |
| **Pre-Conditions** | Gebruiker heeft een geregistreerd account. |
| **Post-Conditions** | Gebruiker is ingelogd op hun account. |
| **Steps** |
| Actor (User) | System |
| 1. Gebruiker opent de inlogpagina. | |
|  | 2. Toont het inlogformulier. |
| 3. Gebruiker vult hun inloggegevens in. | |
|  | 4. Valideert de ingevoerde gegevens en controleert op accountvaliditeit. |
|  | 5. Laat de gebruiker toe tot hun account. |
| **Main Success Scenario** | 
| 1. Gebruiker opent de inlogpagina. |
| 2. Toont het inlogformulier. |
| 3. Gebruiker vult hun inloggegevens in. |
| 4. Valideert de ingevoerde gegevens en controleert op accountvaliditeit. |
| 5. Laat de gebruiker toe tot hun account. |
| 6. **Gebruiker is succesvol ingelogd op hun account.** |
| **Alternative Scenarios** | 
| - **Wrong Scenario: Gebruiker voert onjuiste inloggegevens in.** |
|   1. Systeem toont een foutmelding. |
|   2. Gebruiker wordt gevraagd om opnieuw in te loggen met de juiste gegevens. |
| - **Wrong Scenario: Account is tijdelijk vergrendeld vanwege meerdere mislukte pogingen.** |
|   1. Systeem geeft aan dat het account tijdelijk vergrendeld is. |
|   2. Gebruiker wordt gevraagd om later opnieuw in te loggen of het wachtwoord te herstellen. |
| **Extensions** |
| [Extension Point] UC4: Account verwijderen |

### Use Case 4: UC4 Account verwijderen

| Use Case | UC4: Account verwijderen |
|:----------------|:--------------------------|
| **Description** | Gebruiker verwijdert hun account van het platform. |
| **Actor** | Gebruiker |
| **Trigger(s)** | Gebruiker wil hun account permanent verwijderen. |
| **Pre-Conditions** | Gebruiker is ingelogd op hun account. |
| **Post-Conditions** | Account van de gebruiker is verwijderd, inclusief alle gegevens. |
| **Steps** |
| Actor (User) | System |
| 1. Gebruiker opent de accountverwijderingspagina. | |
|  | 2. Toont bevestigingsinformatie en waarschuwingen. |
| 3. Gebruiker bevestigt de verwijdering en voert eventuele vereiste stappen uit. | |
|  | 4. Verwijdert het account en stuurt een bevestigingsbericht. |
| **Main Success Scenario** | 
| 1. Gebruiker opent de accountverwijderingspagina. |
| 2. Toont bevestigingsinformatie en waarschuwingen. |
| 3. Gebruiker bevestigt de verwijdering en voert eventuele vereiste stappen uit. |
| 4. **Verwijdert het account en stuurt een bevestigingsbericht.** |
| 5. Gebruiker heeft succesvol hun account verwijderd. |
| **Alternative Scenarios** | 
| - **Wrong Scenario: Gebruiker annuleert de verwijdering.** |
|   1. Gebruiker klikt op "Annuleren". |
|   2. Accountverwijdering wordt geannuleerd. |
| - **Wrong Scenario: Systeem kan de verwijdering niet voltooien vanwege technische problemen.** |
|   1. Systeem toont een foutmelding. |
|   2. Gebruiker wordt geadviseerd het opnieuw te proberen. |

### Use Case 6: UC6 Match informatie aangeven

| Use Case | UC6: Match informatie aangeven |
|:----------------|:--------------------------|
| **Description** | Gebruiker geeft aan welke informatie ze zoeken in een match. |
| **Actor** | Gebruiker |
| **Trigger(s)** | Gebruiker wil hun voorkeuren aangeven voor matches. |
| **Pre-Conditions** | Gebruiker is ingelogd op hun account. |
| **Post-Conditions** | Voorkeuren van de gebruiker zijn bijgewerkt. |
| **Steps** |
| Actor (User) | System |
| 1. Gebruiker opent de matchinstellingenpagina. | |
|  | 2. Toont de matchinstellingenpagina. |
| 3. Gebruiker geeft hun voorkeuren aan (bijv. leeftijd, locatie, interesses). | |
|  | 4. Slaat de voorkeuren op en update de matchinstellingen. |
| **Main Success Scenario** | 
| 1. Gebruiker opent de matchinstellingenpagina. |
| 2. Toont de matchinstellingenpagina. |
| 3. Gebruiker geeft hun voorkeuren aan. |
| 4. **Slaat de voorkeuren op en update de matchinstellingen.** |
| 5. Voorkeuren van de gebruiker zijn bijgewerkt. |
| **Alternative Scenarios** | 
| - **Wrong Scenario: Gebruiker annuleert de voorkeuren.** |
|   1. Gebruiker klikt op "Annuleren". |
|   2. Systeem annuleert de wijzigingen en behoudt de vorige matchinstellingen. |
| - **Wrong Scenario: Systeem kan de voorkeuren niet opslaan vanwege technische problemen.** |
|   1. Systeem toont een foutmelding. |
|   2. Gebruiker wordt geadviseerd het opnieuw te proberen. |

### Use Case 7: UC7 Muzieksmaak aangeven

| Use Case | UC7: Muzieksmaak aangeven |
|:----------------|:--------------------------|
| **Description** | Gebruiker geeft hun muzieksmaak aan op hun profiel. |
| **Actor** | Gebruiker |
| **Trigger(s)** | Gebruiker wil hun muzieksmaak delen met anderen. |
| **Pre-Conditions** | Gebruiker is ingelogd op hun account. |
| **Post-Conditions** | Muzieksmaak van de gebruiker is toegevoegd aan hun profiel. |
| **Steps** |
| Actor (User) | System |
| 1. Gebruiker opent de profielbewerkingspagina. | |
|  | 2. Toont de profielbewerkingspagina. |
| 3. Gebruiker voegt muzieksmaak toe aan hun profiel. | |
|  | 4. Slaat de wijzigingen op en update het profiel. |
| **Main Success Scenario** | 
| 1. Gebruiker opent de profielbewerkingspagina. |
| 2. Toont de profielbewerkingspagina. |
| 3. **Gebruiker voegt muzieksmaak toe aan hun profiel.** |
| 4. Slaat de wijzigingen op en update het profiel. |
| 5. Muzieksmaak van de gebruiker is toegevoegd aan hun profiel. |
| **Alternative Scenarios** | 
| - **Wrong Scenario: Gebruiker annuleert de toevoeging van muzieksmaak.** |
|   1. Gebruiker klikt op "Annuleren". |
|   2. Systeem annuleert de wijzigingen en behoudt het vorige profiel. |
| - **Wrong Scenario: Systeem kan de toevoeging van muzieksmaak niet opslaan vanwege technische problemen.** |
|   1. Systeem toont een foutmelding. |
|   2. Gebruiker wordt geadviseerd het opnieuw te proberen. |

### Use Case 8: UC8 Interesses aangeven

| Use Case | UC8: Interesses aangeven |
|:----------------|:--------------------------|
| **Description** | Gebruiker geeft hun interesses aan op hun profiel. |
| **Actor** | Gebruiker |
| **Trigger(s)** | Gebruiker wil hun interesses delen op hun profiel. |
| **Pre-Conditions** | Gebruiker is ingelogd op hun account. |
| **Post-Conditions** | Interesses van de gebruiker zijn toegevoegd aan hun profiel. |
| **Steps** |
| Actor (User) | System |
| 1. Gebruiker opent de profielbewerkingspagina. | |
|  | 2. Toont de profielbewerkingspagina. |
| 3. Gebruiker voegt hun interesses toe aan het daarvoor bestemde gedeelte. | |
|  | 4. Slaat de wijzigingen op en update het profiel. |
| **Main Success Scenario** | 
| 1. Gebruiker opent de profielbewerkingspagina. |
| 2. Toont de profielbewerkingspagina. |
| 3. **Gebruiker voegt hun interesses toe aan het daarvoor bestemde gedeelte.** |
| 4. Slaat de wijzigingen op en update het profiel. |
| 5. Interesses van de gebruiker zijn toegevoegd aan hun profiel. |
| **Alternative Scenarios** | 
| - **Wrong Scenario: Gebruiker annuleert het toevoegen van interesses.** |
|   1. Gebruiker klikt op "Annuleren". |
|   2. Systeem annuleert de wijzigingen en behoudt het vorige profiel. |
| - **Wrong Scenario: Systeem kan de toegevoegde interesses niet opslaan vanwege technische problemen.** |
|   1. Systeem toont een foutmelding. |
|   2. Gebruiker wordt geadviseerd het opnieuw te proberen. |

### Use Case 9: UC9 Matches swipen

| Use Case | UC9: Matches swipen |
|:----------------|:--------------------------|
| **Description** | Gebruiker bekijkt en beoordeelt potentiële matches door te swipen. |
| **Actor** | Gebruiker |
| **Trigger(s)** | Gebruiker wil nieuwe matches ontdekken en beoordelen. |
| **Pre-Conditions** | Gebruiker is ingelogd op hun account en heeft matches beschikbaar. |
| **Post-Conditions** | De beoordeling van de gebruiker wordt vastgelegd voor elke geswipe-de match. |
| **Steps** |
| Actor (User) | System |
| 1. Gebruiker opent de matchoverzichtspagina. | |
|  | 2. Toont de beschikbare matches. |
| 3. Gebruiker swipet naar links (afwijzen) of rechts (accepteren) voor elke match. | |
|  | 4. Systeem registreert de gebruikersbeoordeling voor elke match. |
| **Main Success Scenario** | 
| 1. Gebruiker opent de matchoverzichtspagina. |
| 2. Toont de beschikbare matches. |
| 3. **Gebruiker swipet naar links of rechts voor elke match.** |
| 4. Systeem registreert de gebruikersbeoordeling voor elke match. |
| 5. Gebruiker heeft succesvol matches beoordeeld. |
| **Alternative Scenarios** | 
| - **Wrong Scenario: Gebruiker annuleert het swipen.** |
|   1. Gebruiker stopt met swipen en sluit de app. |
|   2. Gebruikersbeoordeling wordt niet vastgelegd voor niet-geswipede matches. |
| - **Wrong Scenario: Systeem kan de gebruikersbeoordeling niet vastleggen vanwege technische problemen.** |
|   1. Systeem toont een foutmelding. |
|   2. Gebruiker wordt geadviseerd het opnieuw te proberen.

### Use Case 10: UC10 Berichten sturen

| Use Case | UC10: Berichten sturen |
|:----------------|:--------------------------|
| **Description** | Gebruiker stuurt berichten naar matches met wie ze gematcht zijn. |
| **Actor** | Gebruiker |
| **Trigger(s)** | Gebruiker wil communiceren met hun matches. |
| **Pre-Conditions** | Gebruiker is ingelogd op hun account en heeft gematchte gebruikers. |
| **Post-Conditions** | Het verzonden bericht wordt vastgelegd in de berichtengeschiedenis. |
| **Steps** |
| Actor (User) | System |
| 1. Gebruiker opent het berichtenscherm met een gematchte gebruiker. | |
|  | 2. Toont het berichtenscherm met de chatgeschiedenis. |
| 3. Gebruiker typt en verzendt een bericht naar hun match. | |
|  | 4. Systeem registreert het verzonden bericht in de chatgeschiedenis. |
| **Main Success Scenario** | 
| 1. Gebruiker opent het berichtenscherm met een gematchte gebruiker. |
| 2. Toont het berichtenscherm met de chatgeschiedenis. |
| 3. **Gebruiker typt en verzendt een bericht naar hun match.** |
| 4. Systeem registreert het verzonden bericht in de chatgeschiedenis. |
| 5. Gebruiker heeft succesvol een bericht verzonden naar hun match. |
| **Alternative Scenarios** | 
| - **Wrong Scenario: Gebruiker annuleert het verzenden van het bericht.** |
|   1. Gebruiker sluit het berichtenscherm zonder een bericht te verzenden. |
|   2. Het bericht wordt niet vastgelegd in de chatgeschiedenis. |
| - **Wrong Scenario: Systeem kan het verzonden bericht niet registreren vanwege technische problemen.** |
|   1. Systeem toont een foutmelding. |
|   2. Gebruiker wordt geadviseerd het opnieuw te proberen.

### Use Case 11: UC11 Foto insturen

| Use Case | UC11: Foto insturen |
|:----------------|:--------------------------|
| **Description** | Gebruiker stuurt een foto naar hun match. |
| **Actor** | Gebruiker |
| **Trigger(s)** | Gebruiker wil een foto delen met hun match. |
| **Pre-Conditions** | Gebruiker is ingelogd op hun account en heeft een actieve chat met de match. |
| **Post-Conditions** | De verzonden foto wordt toegevoegd aan de chatgeschiedenis. |
| **Steps** |
| Actor (User) | System |
| 1. Gebruiker opent het berichtenscherm met een match. | |
|  | 2. Toont het berichtenscherm met de chatgeschiedenis. |
| 3. Gebruiker selecteert en verzendt een foto naar hun match. | |
|  | 4. Systeem voegt de verzonden foto toe aan de chatgeschiedenis. |
| **Main Success Scenario** | 
| 1. Gebruiker opent het berichtenscherm met een match. |
| 2. Toont het berichtenscherm met de chatgeschiedenis. |
| 3. **Gebruiker selecteert en verzendt een foto naar hun match.** |
| 4. Systeem voegt de verzonden foto toe aan de chatgeschiedenis. |
| 5. Gebruiker heeft succesvol een foto verzonden naar hun match. |
| **Alternative Scenarios** | 
| - **Wrong Scenario: Gebruiker annuleert het verzenden van de foto.** |
|   1. Gebruiker sluit het fotoselectiescherm zonder een foto te verzenden. |
|   2. De foto wordt niet toegevoegd aan de chatgeschiedenis. |
| - **Wrong Scenario: Systeem kan de verzonden foto niet toevoegen aan de chatgeschiedenis vanwege technische problemen.** |
|   1. Systeem toont een foutmelding. |
|   2. Gebruiker wordt geadviseerd het opnieuw te proberen. |

## Sequence Diagram
![diagram-export-1-14-2024-9_51_00-PM](https://github.com/Jaymian-Lee/HeartSyncv2/assets/56151997/1091f4d4-5061-415f-af98-25226b638666)

## Activity Diagram
![Activity diagram - HeartSync](https://github.com/Jaymian-Lee/HeartSyncv2/assets/56151997/0a0be9d1-384e-452a-b7ff-f17e2b1f6b82)

## State Diagram
![State diagram - HeartSync drawio](https://github.com/Jaymian-Lee/HeartSyncv2/assets/56151997/12a04bdb-9b34-4fb3-b7c6-248bd4883ad6)

## 

## Lijst met data
Op basis van de informatie die je hebt verstrekt, kun je de volgende lijst met benodigde data opstellen:

## ERD

``    User:
        Username (Primary Key, Unique)
        Email (Unique)
        Password

    Profile:
        Name
        Age
        Location
        Profile Photo
        Profile Information
        Privacy Settings
        *User_ID (Foreign Key referencing User)

    Music Interests:
        Selected Music Interests (List)
        General Music Preferences
        Quiz Results
        *User_ID (Foreign Key referencing User)

    Chats:
        Messages
        Photos
        Favorite Conversations
        *User_ID (Foreign Key referencing User)
        *Match_ID (Foreign Key referencing Matches)

    Matches:
        Matched User_IDs (List)
        Search Criteria
        Music Interests
        *User_ID (Foreign Key referencing User)

    App Settings:
        Language Preference
        Notification Preferences
        Dark Mode Preference
        Biometric Data
        *User_ID (Foreign Key referencing User)

    Account Management:
        Account Deletion Options
        Deactivation Options
        *User_ID (Foreign Key referencing User)``
![diagram-export-1-14-2024-10_14_30-PM](https://github.com/Jaymian-Lee/HeartSyncv2/assets/56151997/7fda3ef9-7f41-4098-bf47-5b8bd37a7cd1)

    

1. **Registratie:**
   - Gebruikersnaam
   - E-mailadres
   - Wachtwoord

2. **Inloggen:**
   - Gebruikersnaam of E-mailadres
   - Wachtwoord

3. **Muziekinteresses:**
   - Geselecteerde muziekinteresses (via buttons)
   - Algemene muziekvoorkeuren
   - Quizresultaten

4. **Profielinformatie:**
   - Naam
   - Leeftijd
   - Locatie
   - Profielfoto
   - Profielinformatie
   - Privacyinstellingen

5. **Chats:**
   - Berichten
   - Foto's
   - Favoriete gesprekken
   - Quizresultaten van matches

6. **Matches**
   - Matches
   - Zoekcriteria
   - Muziekinteresses

7. **App-instellingen:**
   - Taalvoorkeur
   - Notificatievoorkeuren
   - Donkere modusvoorkeur
   - Biometrische gegevens

8. **Accountbeheer:**
   - Accountverwijdering
   - Deactiveringsmogelijkheden


