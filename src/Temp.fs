



// if allUsers.Contains(username) then
//             if setOfLoggedInUsers.Contains(username) then
//                 let mutable tempList = mapUserNametoTweets.TryFind(username)
//                 match tempList with 
//                 | Some llist ->
//                     let mutable temp : List<string> = list.Empty
//                     temp <- temp @ [tweet]
//                     mapUserNametoTweets <- mapUserNametoTweets.Add(username, temp)
//                 | None llist->
//                     mapUserNametoTweets <- mapUserNametoTweets.Add(username, list.Empty)
//                     let mutable temp = mapUserNametoTweets.TryFind(username)
//                     match temp with 
//                     | Some llist->
//                         temp <- temp @[tweet]
//                         mapUserNametoTweets <- mapUserNametoTweets.Add(username, temp)
//                     | None ->
//                         printfn "Key not exist"
                        
//                 let res = splitLine tweet
//                 for value in res do
//                     if value.Contains("#") then
//                         if mapUserToHashTags.ContainsKey(value.[1..value.Length]) then
//                             mapUserToHashTags <- mapUserToHashTags.Add(value.[1..value.Length], mapUserToHashTags.[value.[1..value.Length]].Add(tweet))
//                         else 
//                             mapUserToHashTags <- mapUserToHashTags.Add(value.[1..value.Length], Set.empty)
//                             mapUserToHashTags <- mapUserToHashTags.Add(value.[1..value.Length], mapUserToHashTags.[value.[1..value.Length]].Add(tweet))

//                     if value.Contains("@") then
//                         if mapUserToMentionTags.ContainsKey(value.[1..value.Length]) then
//                             mapUserToMentionTags <- mapUserToMentionTags.Add(value.[1..value.Length], mapUserToMentionTags.[value.[1..value.Length]].Add(tweet))
//                         else 
//                             mapUserToMentionTags <- mapUserToMentionTags.Add(value.[1..value.Length], Set.empty)
                            
//                             mapUserToMentionTags <- mapUserToMentionTags.Add(value.[1..value.Length], mapUserToMentionTags.[value.[1..value.Length]].Add(tweet))

//                 printfn "Total Registered Users: %i\nTotal Online Users: %i\nTotal Offline Users: %i\nTotal Tweets: %i\nTotal ReTweets: %i\n" totalUsers loggedInUsers loggedOutUsers totalTweets totalReTweets

//                 printfn "User to Tweets: %A" mapUserNametoTweets
//                 printfn "User %s Tweeted:  \"%s\" " username tweet
//                 Ok{userId = username ; tweet =  tweet}
               
//             else 
//                 let err = sprintf "User not logged in."
//                 Error(Http.Status.Forbidden, {error = err}) 
//         else 
//             let err = sprintf "User not logged in."
//             Error(Http.Status.Forbidden, {error = err}) 
