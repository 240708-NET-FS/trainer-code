import React, {useEffect, useState }from 'react'
import PostList from '../PostList/PostList'
import axios from 'axios';


function DataFetcher() {

    //Using useState to manage the data returned from the API (should be user forum posts)
    const [posts, setPosts] = useState<{ id: number; title: String;}[] | null>(null);

    const url = 'https://jsonplaceholder.typicode.com/posts';

    //Using useEffect to send a GET via Axios, whenever this component is rendered.
    //useEffect is a function that expects two things as arguments when it is called.
    //First it expects, a function. You can either define one outside of the useEffect call, 
    //OR (more commonly) you use a lambda to write the function inside of the useEffect call. 
    //Second, it expects an array of dependencies. Even if you have none, you need to provide an
    //empty array. 
    useEffect(() => {
        async function fetchPosts() {
            try {
                //Using Axios to fetch data from JSONPlaceholder API
                const response = await axios.get(url);
                
                //Send the fetched data to my state, only saving the first 5
                setPosts(response.data.slice(0,5));

            } catch (error) {
                console.error('Error fetching posts: ', error)
            }
        }// End fetchPosts

        //Calling my fetchPosts() method to get my posts
        fetchPosts();
        
    }, [url]); //End useEffect lambda, notice the empty dependency array

  return (
    <div>
        <h3>Here are my posts: </h3>
        {/*Passing the fetched posts from the above code, as props into my PostList child component */}
        {posts ? <PostList posts={posts} /> : <p>Loading posts...</p>}
    </div>
    
  );
}

export default DataFetcher