import React from "react";
import {render, screen} from '@testing-library/react'
import PostList from "./PostList";
import {test} from '@jest/globals' 
import '@testing-library/jest-dom';


//Mocking some posts to test for, just using some 
const mockPosts = [
    { id: 1, title: 'Post 1'},
    { id: 2, title: 'Post 2'},
    { id: 3, title: 'Post 3'}
];

//Writing my tests.... 

//Starting with rendering a list of posts.
test('renders a list of posts', () => {
    //Render a PostList component with the mock data from above
    render(<PostList posts={mockPosts} />);

    //Check that each post title from above is rendered inside of the virtual dom as expected
    mockPosts.forEach(post => {
        expect(screen.getByText(post.title)).toBeInTheDocument();
    });
});

//What happens if we have an empty list?
test('renders an empty list if no posts are provided', () => {
    
    render(<PostList posts={[]}/>);

    expect(screen.queryByRole('listitem')).toBeNull();
})