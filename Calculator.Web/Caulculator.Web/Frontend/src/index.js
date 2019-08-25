// Required modules (React)
import React from 'react';
import ReactDOM from 'react-dom';

import 'bootstrap/dist/css/bootstrap.min.css';

// Get app structure with specific routes
import { createRouteStructure } from './routing/routes'; 


import { Offline, Online } from 'react-detect-offline';

ReactDOM.render(

    <div>
        <Online>{createRouteStructure()}</Online>
        <Offline>Chyba sitě</Offline>
    </div>
     ,
     
     document.getElementById('root')
);