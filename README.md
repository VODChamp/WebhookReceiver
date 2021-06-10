# VODChamp - Twitch Webhook Receiver

This project handles the incoming webhook payloads from Twitch.

## Process

  1. Receive webhook from Twitch
  2. Deserialize payload
  3. Check DB for duplicates
  4. Push event to the `streamparse` message queue
  5. Save event to the DB

## License

See LICENSE

