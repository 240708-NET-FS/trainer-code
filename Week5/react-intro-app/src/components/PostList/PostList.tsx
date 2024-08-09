import React from 'react'

//Because we're using typescript, we want to use an interface to define the shape of our props
interface PostListProps {
    posts: {id: number; title: String;}[];
}

function PostList( { posts }: PostListProps) {

    //My PostList will recieve the posts from jsonplaceholder as Props. They are stored in the state,
    //of PostList's parent, DataFetcher. 
    
  return (
    <ul>
        {/*Using map to iterate over our list of posts, that comes in via props and render each post*/}
        {
            posts.map((post) => (
                <li key={post.id}>
                    <strong>{post.title}</strong>
                </li>
            ))
        }
    </ul>
  )
}

export default PostList