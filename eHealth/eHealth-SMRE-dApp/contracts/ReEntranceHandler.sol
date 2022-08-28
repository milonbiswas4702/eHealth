pragma solidity 0.8.0;

contract ReEntranceHandler {
    bool internal locked;
    modifier NoReEntrant() {
        require(!locked, "No Re-Entrancy");
        locked = true;
        _;
        locked = false;
    }
}
