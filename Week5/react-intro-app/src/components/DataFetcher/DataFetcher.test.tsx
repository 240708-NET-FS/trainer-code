import React from "react";
import {render, screen, waitFor} from '@testing-library/react'
import axios from "axios";
import AxiosMockAdapter from 'axios-mock-adapter';
import {test} from '@jest/globals' 
import DataFetcher from "./DataFetcher";
import '@testing-library/jest-dom';

//Create an instance of our AxiosMockAdapter so we can mock requests
const mockAdapter = new AxiosMockAdapter(axios);

//Mock some posts for our mock request's return
const mockPosts = [
    { id: 1, title: 'Post 1'},
    { id: 2, title: 'Post 2'},
    { id: 3, title: 'Post 3'}
];

//Clearing my mocks between tests (if i have multiple tests in here with the same mockAdapter)
beforeEach(() => {
    mockAdapter.reset(); //Resetting my mock adapter 
})

//First test, seeing if we can get some posts (fake posts, that I declared above)
test('fetches and displays posts', async () => {

    //Mock a successful get request
    mockAdapter.onGet('https://jsonplaceholder.typicode.com/posts').reply(200, mockPosts);

    //Rendering my DataFetcher component (the thing we are testing)
    render(<DataFetcher />);

    //Checking to see if our "Loading..." text initially appears
    expect(screen.getByText("Loading posts...")).toBeInTheDocument();

    //Actually sending off our fake axios request and rendering based on the reply we configured
    await waitFor(() => {
        mockPosts.forEach(post => {
            expect(screen.getByText(post.title)).toBeInTheDocument();
        });
    });

});// End test 


