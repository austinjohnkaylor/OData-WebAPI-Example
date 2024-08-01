# Overview
This document describes the how Entity Framework is setup in the Shared project

It also details what the entities are and how they relate to each other

## Entities
### Customer
- Represents a customer in the e-commerce system
- Has a one-to-many relationship with Order (a customer can have multiple orders).
### Order
- Represents an order in the e-commerce system
- Has a many-to-one relationship with Customer (an order belongs to one customer).
- Has a one-to-many relationship with OrderItem (an order can have multiple order items).
### OrderItem
- Represents an item in an order in the e-commerce system
- Has a many-to-one relationship with Order (an order item belongs to one order).
- Has a many-to-one relationship with Product (an order item refers to one product).
### Product
- Represents a product in the e-commerce system
- Has a one-to-many relationship with OrderItem (a product can be part of multiple order items).