

/* Q1: First Match
------------------*/

select SC.country_name from [dbo].[match_details] MD inner join [dbo].[Soccer Country] SC
on MD.team_id = SC.country_id where MD.match_no = 1

/* Q2: Champion
------------------*/

select SC.country_name from [dbo].[match_details] MD inner join [dbo].[Soccer Country] SC
on MD.team_id = SC.country_id where MD.play_stage = 'F' and MD.win_lose = 'W'

/* Q3: Most Viewd Game
------------------*/

select SC.country_name, MM.audence 'Number of Audience' from [dbo].[match_mast] MM inner join [dbo].[match_details] MD 
on MM.match_no = MD.match_no inner join [dbo].[Soccer Country] SC
on SC.country_id = MD.team_id where audence = (Select max(audence) from match_mast)

/* Q4: Portugal Hungary Game Result
------------------*/

select SC.country_name, MD.goal_score 'Result' from [dbo].[match_mast] MM inner join [dbo].[match_details] MD 
on MM.match_no = MD.match_no inner join [dbo].[Soccer Country] SC
on SC.country_id = MD.team_id where EXISTS (select * from match_details where SC.country_id = 1209 or country_id = 1214) and MD.goal_score = 3

/* Q5: Runner-Up 
------------------*/

select SC.country_name from [dbo].[match_details] MD inner join [dbo].[Soccer Country] SC
on MD.team_id = SC.country_id where MD.play_stage = 'F' and MD.win_lose = 'L'

/* Q6: Runner-Up 
------------------*/

select country_name , match_no , goal_score 'Goals', MD.win_lose 'Match Result' from [dbo].[match_details] as MD 
inner join [dbo].[Soccer Country] as SC
on MD.team_id = SC.country_id where decided_by = 'N'
group by country_name , match_no , goal_score, win_lose

/* Q7: Host Country
------------------*/

select TOP(1) SCC.country_name from [dbo].[Soccer Country] SCC inner join [dbo].[Soccer_city] SC 
on SCC.country_id = SC.country_id