import React from 'react'
import * as FaIcons from "react-icons/fa"
import * as AiIcons from "react-icons/ai"
import LocalOfferIcon from '@material-ui/icons/LocalOffer';
import PeopleAltIcon from '@material-ui/icons/PeopleAlt';

export const SidebarData =[
    {
        title: "Home",
        path: "/",
        icon: <AiIcons.AiFillHome/>,
        cName: 'nav-text',
    },
    {
        title: 'Product',
        path: '/product',
        icon: <FaIcons.FaCartPlus/>,
        cName: 'nav-text',
    },
    {
        title: 'Category',
        path: '/category',
        icon: <AiIcons.AiFillHome/>,
        cName: 'nav-text',
    },
    {
        title: 'Brand',
        path: '/brand',
        icon: <LocalOfferIcon/>,
        cName: 'nav-text',
    },
    {
        title: 'Customer',
        path: '/customer',
        icon: <PeopleAltIcon/>,
        cName: 'nav-text',
    },
]
