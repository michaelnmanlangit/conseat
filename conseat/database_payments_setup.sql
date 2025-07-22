-- SQL script to create the payments table for the concert seating system
-- Run this script in your MySQL database (concertdb) if the table doesn't exist

CREATE TABLE IF NOT EXISTS tbl_payments (
    id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    concert_id VARCHAR(50) NOT NULL,
    seat_type VARCHAR(50) NOT NULL,
    seat_id VARCHAR(50) NOT NULL,
    payment_method VARCHAR(50) NOT NULL,
    payment_number VARCHAR(100) NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    payment_date DATETIME NOT NULL,
    payment_status VARCHAR(20) DEFAULT 'Completed',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    
    -- Foreign key constraints (optional, uncomment if you have proper foreign key setup)
    -- FOREIGN KEY (user_id) REFERENCES users(id),
    -- FOREIGN KEY (concert_id) REFERENCES concert_events(id),
    
    -- Indexes for better performance
    INDEX idx_user_id (user_id),
    INDEX idx_concert_id (concert_id),
    INDEX idx_payment_date (payment_date),
    INDEX idx_payment_status (payment_status)
);

-- Note: The existing tbl_seats table structure appears to be:
-- tbl_seats (id, concert_id, user_id, seat_type, seat_id, is_reserved)
-- No additional columns need to be added to the existing tbl_seats table.

-- To view the current structure of your tbl_seats table, run:
-- DESCRIBE tbl_seats;