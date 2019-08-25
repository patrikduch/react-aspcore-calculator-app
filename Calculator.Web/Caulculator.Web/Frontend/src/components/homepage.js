import React from 'react';
import { Link } from 'react-router-dom';

// Custom modules
import { routes } from '../routing/routes'; 

// Nested required components
import ClientHeader from './client/client-header';
import ClientContent from './client/client-content';
import ClientFooter from './client/client.footer';




class HomePage  extends React.Component {

    render(){
        return (
            <div>
                <ClientHeader />
                <ClientContent />
                <ClientFooter />
            </div>
        );
    }
}

export default HomePage;