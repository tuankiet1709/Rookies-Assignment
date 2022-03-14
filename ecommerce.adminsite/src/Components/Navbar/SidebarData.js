import React from 'react'
import * as FaIcons from "react-icons/fa"
import * as AiIcons from "react-icons/ai"

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
]
